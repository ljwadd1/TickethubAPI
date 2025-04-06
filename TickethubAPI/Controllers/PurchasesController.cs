using Azure.Storage.Queues;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using System.Text;

namespace TickethubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly ILogger<PurchasesController> _logger;
        private readonly IConfiguration _configuration;

        public PurchasesController(ILogger<PurchasesController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Purchases Controller GET()");
        }

        // Receive data from client
        [HttpPost]
        public async Task<IActionResult> Post(Purchase purchase)
        {
            // Validation 
            if(ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            // Send purchase to Azure queue
            string queueName = "tickethub";

            // Get connection string from secrets.json
            string? connectionString = _configuration["AzureStorageConnectionString"];

            // If null or blank, crash program
            if (string.IsNullOrEmpty(connectionString))
            {
                return BadRequest("An error was encountered");
            }

            QueueClient queueClient = new QueueClient(connectionString, queueName);

            // serialize an object to json
            string message = JsonSerializer.Serialize(purchase);

            // send string message to queue (must encode as base64 to work properly)
            var plainTextBytes = Encoding.UTF8.GetBytes(message);
            await queueClient.SendMessageAsync(Convert.ToBase64String(plainTextBytes));


            // Return a response for valid request
            return Ok("Hello " + purchase.Name + ". Purchase added to Azure Tickethub queue.");
        }

    }
}
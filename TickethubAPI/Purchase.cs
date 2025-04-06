using System.ComponentModel.DataAnnotations;

namespace TickethubAPI
{
    public class Purchase
    {
        [Required]
        public int ConcertId { get; set; } = 0;

        [EmailAddress]
        [Required]
        public string Email { get; set; } = string.Empty;

        [MaxLength(60)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; } = 0;

        [Required]
        public string CreditCard { get; set; } = string.Empty;

        [Required]
        public string Expiration { get; set; } = string.Empty;

        [Required]
        public string SecurityCode { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string Province { get; set; } = string.Empty;

        [Required]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        public string Country { get; set; } = string.Empty;

    }
}



// ---
// payload schema

//{
//    "concertId": 0,
//  "email": "string",
//  "name": "string",
//  "phone": "string",
//  "quantity": 0,
//  "creditCard": "string",
//  "expiration": "string",
//  "securityCode": "string",
//  "address": "string",
//  "city": "string",
//  "province": "string",
//  "postalCode": "string",
//  "country": "string"
//}
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TickethubAPI
{
    public class Purchase
    {
        [Range(1, int.MaxValue, ErrorMessage = "Concert ID must be a positive integer.")]
        [Required(ErrorMessage = "Concert ID is required.")]
        public int ConcertId { get; set; } = 0;

        [EmailAddress(ErrorMessage = "Invalid Email Address entered.")]
        [Required(ErrorMessage = "Email Address is required.")]
        public string Email { get; set; } = string.Empty;

        [MaxLength(60, ErrorMessage = "Name cannot exceed 60 characters.")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Invalid Phone Number entered.")]
        [Required(ErrorMessage = "Phone Number is required.")]
        public string Phone { get; set; } = string.Empty;

        [Range(1, 10, ErrorMessage = "Quantity must be between 1 and 10.")]
        [Required(ErrorMessage = "Quantity is required.")]
        public int Quantity { get; set; } = 0;

        [CreditCard(ErrorMessage = "Invalid Credit Card number entered. Card number must be exactly 16 digits.")]
        [Required(ErrorMessage = "Credit Card is required.")]
        public string CreditCard { get; set; } = string.Empty;

        // Future: Verify card is not expired already
        [RegularExpression(@"^(0[1-9]|1[0-2])/[0-9]{2}$", ErrorMessage = "Expiration date must be in MM/YY format.")]
        [Required]
        public string Expiration { get; set; } = string.Empty;

        [RegularExpression(@"^\d{3}$", ErrorMessage = "Security Code must be exactly 3 digits.")]
        [Required(ErrorMessage = "Security Code is required.")]
        public string SecurityCode { get; set; } = string.Empty;

        [MaxLength(100, ErrorMessage = "Address cannot exceed 100 characters.")]
        [RegularExpression(@"^\d+\s.*", ErrorMessage = "Invalid Address format. Address must start with a number followed by a space.")]
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; } = string.Empty;

        [MaxLength(60, ErrorMessage = "City cannot exceed 60 characters.")]
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "Province cannot exceed 30 characters.")]
        [Required(ErrorMessage = "Province is required.")]
        public string Province { get; set; } = string.Empty;

        [RegularExpression(@"^[A-Z]\d[A-Z]\d[A-Z]\d$", ErrorMessage = "Invalid Postal Code format. Postal code must be 6 characters without a space. Letters must be capitalized. Ex: A1A1A1")]
        [Required(ErrorMessage = "Postal Code is required.")]
        public string PostalCode { get; set; } = string.Empty;

        [MaxLength(60, ErrorMessage = "Country cannot exceed 60 characters.")]
        [Required(ErrorMessage = "Country is required.")]
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
using System.ComponentModel.DataAnnotations;

namespace WilliamExpress.Shared.Domain
{
    public class Shippingaddress : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First name does not meet length requirements")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last Name does not meet length requirements")]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Apartment { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"(6|8|9)\d{7}}", ErrorMessage = "Contact Number is not a valid phone number")]
        public string PhoneNumber { get; set; }

    }
}

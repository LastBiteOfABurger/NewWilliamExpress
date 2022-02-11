using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WilliamExpress.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Username does not meet length requirements")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not an valid Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        //[Required]
        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"(6|8|9)\d{7}}", ErrorMessage = "Contact Number is not a valid phone number")]
        public string ContactNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public string Rating { get; set; }
        public virtual List<Item> Items { get; set; }


    }
}

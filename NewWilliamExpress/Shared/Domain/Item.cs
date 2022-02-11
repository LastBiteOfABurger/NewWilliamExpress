

using System.ComponentModel.DataAnnotations;

namespace WilliamExpress.Shared.Domain
{
    public class Item : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Username does not meet length requirements")]
        public string Itemname { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Username does not meet length requirements")]
        public string Wear { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 20, ErrorMessage = "Username does not meet length requirements")]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public int ItemtypeId { get; set; }
        public virtual Itemtype Itemtype { get; set; }
        //public int CustomerId { get; set; }
        //public virtual Customer Customer { get; set; }

    }
}

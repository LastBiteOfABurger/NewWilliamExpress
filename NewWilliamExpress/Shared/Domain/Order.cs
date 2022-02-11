using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WilliamExpress.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        [Required]
        [DataType(DataType.Currency)]
        public double TotalPrice { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public virtual List<Item> Items { get; set; }
        public int ShippingaddressId { get; set; }
        public virtual Shippingaddress Shippingaddress { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WilliamExpress.Shared.Domain
{
    public class Itemtype : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}

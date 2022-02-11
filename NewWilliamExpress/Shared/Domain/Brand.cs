using System.ComponentModel.DataAnnotations;

namespace WilliamExpress.Shared.Domain
{
    public class Brand : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}

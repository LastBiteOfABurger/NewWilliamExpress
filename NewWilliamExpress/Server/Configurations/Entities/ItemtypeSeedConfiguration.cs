using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Configurations.Entities
{
    public class ItemtypeSeedConfiguration : IEntityTypeConfiguration<Itemtype>
    {
        public void Configure(EntityTypeBuilder<Itemtype> builder)
        {
            builder.HasData(
                     new Itemtype
                     {
                         Id = 1,
                         Name = "Short pants denim",
                     },
                     new Itemtype
                     {
                         Id = 2,
                         Name = "long jeans denim",
                     },
                     new Itemtype
                     {
                         Id = 3,
                         Name = "Short sleeve polo",
                     },
                     new Itemtype
                     {
                         Id = 4,
                         Name = "long sleeve polo",
                     },
                     new Itemtype
                     {
                         Id = 5,
                         Name = "Tshirt",
                     }
                    );
        }
    }
}

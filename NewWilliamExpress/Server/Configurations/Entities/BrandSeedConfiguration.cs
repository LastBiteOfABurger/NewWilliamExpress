using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Configurations.Entities
{
    public class BrandSeedConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                     new Brand
                     {
                         Id = 1,
                         Name = "Uniqlo",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Brand
                     {
                         Id = 2,
                         Name = "CottonOn",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Brand
                     {
                         Id = 3,
                         Name = "Zara",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     }
);
        }
    }
}

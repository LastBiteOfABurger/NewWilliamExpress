using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Configurations.Entities
{
    public class OrderSeedConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                     new Order
                     {
                         Id = 1,
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         ShippingaddressId = 2,
                         CreatedBy = "System",
                         UpdatedBy = "System"

                     },
                     new Order
                     {
                         Id = 2,
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         ShippingaddressId = 1,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Order
                     {
                         Id = 3,
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         ShippingaddressId = 3,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Order
                     {
                         Id = 4,
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         ShippingaddressId = 1,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Order
                     {
                         Id = 5,
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         ShippingaddressId = 2,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     }

                    );
        }
    }
}


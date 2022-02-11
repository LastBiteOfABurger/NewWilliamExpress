using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Configurations.Entities
{
    public class ShippingaddressSeedConfiguration : IEntityTypeConfiguration<Shippingaddress>
    {
        public void Configure(EntityTypeBuilder<Shippingaddress> builder)
        {
            builder.HasData(
                     new Shippingaddress
                     {
                         Id = 1,
                         FirstName = "Joe",
                         LastName = "Lim",
                         Address = "Pasir ris",
                         Apartment = "HDB",
                         City = "Singapore",
                         Country = "Singapore",
                         PostalCode = "342",
                         PhoneNumber = "989898989",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Shippingaddress
                     {
                         Id = 2,
                         FirstName = "Joe",
                         LastName = "Mama",
                         Address = "Bedok st",
                         Apartment = "HDB",
                         City = "Singapore",
                         Country = "Singapore",
                         PostalCode = "342",
                         PhoneNumber = "989898989",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"

                     },
                     new Shippingaddress
                     {

                         Id = 3,
                         FirstName = "Joe",
                         LastName = "Dad",
                         Address = "Tampines",
                         Apartment = "HDB",
                         City = "Singapore",
                         Country = "Singapore",
                         PostalCode = "342",
                         PhoneNumber = "989898989",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     }

                    );
        }
    }
}

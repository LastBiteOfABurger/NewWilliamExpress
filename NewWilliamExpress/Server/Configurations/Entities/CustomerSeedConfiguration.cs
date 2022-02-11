using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                     new Customer
                     {
                         Id = 1,
                         Username = "Joe",
                         EmailAddress = "Joe@gmail.com",
                         ContactNumber = "90909090",
                         Password = "Joe1",
                         Rating = "3",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Customer
                     {
                         Id = 2,
                         Username = "Dan",
                         EmailAddress = "Dan@gmail.com",
                         ContactNumber = "80808080",
                         Password = "Dan1",
                         Rating = "4",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Customer
                     {
                         Id = 3,
                         Username = "Sally",
                         EmailAddress = "Sally@gmail.com",
                         ContactNumber = "81818181",
                         Password = "Sally1",
                         Rating = "5",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     }


);
        }
    }
}

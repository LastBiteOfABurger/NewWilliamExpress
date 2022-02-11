using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                     new Staff
                     {
                         Id = 1,
                         StaffName = "Danniel",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Staff
                     {
                         Id = 2,
                         StaffName = "William",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     }
);
        }
    }
}

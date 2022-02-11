using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NewWilliamExpress.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilliamExpress.Server.Configurations.Entities;
using WilliamExpress.Shared.Domain;

namespace NewWilliamExpress.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Shippingaddress> Shippingaddress { get; set; }
        public DbSet<Itemtype> Itemtype { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new BrandSeedConfiguration());
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            builder.ApplyConfiguration(new ItemSeedConfiguration());
            builder.ApplyConfiguration(new ItemtypeSeedConfiguration());
            //builder.ApplyConfiguration(new OrderSeedConfiguration());
            builder.ApplyConfiguration(new ShippingaddressSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());

        }
    }
    
}

//using WilliamExpress.Server.Configurations.Entities;
//using WilliamExpress.Shared.Domain;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace WilliamExpress.Server.Context
//{
//    public class ItemContext : DbContext
//    {
//        public ItemContext(DbContextOptions options)
//            :base(options)
//        {
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.ApplyConfiguration(new ItemSeedConfiguration());
//        }

//        public DbSet<Item> Items { get; set; }
//    }
//}

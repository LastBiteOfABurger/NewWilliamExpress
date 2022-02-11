using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Configurations.Entities
{
    public class ItemSeedConfiguration : IEntityTypeConfiguration<Item>
    {

        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasData(
                     new Item
                     {
                         Id = 1,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 2,
                         Quantity = 35,
                         Itemname = "Shorts denim pants medium",
                         Wear = "new",
                         Price = 200,
                         Image = "https://localhost:44376/StaticFiles/Images/shorts1.jfif",
                         Description = "very nice please buy",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 2,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 1,
                         Quantity = 35,
                         Itemname = "long denium jeans large",
                         Wear = "new",
                         Price = 300,
                         Image = "https://localhost:44376/StaticFiles/Images/jean1.png",
                         Description = "Best quality",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 3,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 3,
                         Quantity = 35,
                         Itemname = "TShirt Small",
                         Wear = "new",
                         Price = 250,
                         Image = "https://localhost:44376/StaticFiles/Images/tshirt1.jpg",
                         Description = "very good",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 4,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 1,
                         Quantity = 35,
                         Itemname = "long sleeve Polo T",
                         Wear = "new",
                         Price = 400,
                         Image = "https://localhost:44376/StaticFiles/Images/polot1.png",
                         Description = "give me money",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 5,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 3,
                         Quantity = 35,
                         Itemname = "long sleeve Tshirt",
                         Wear = "new",
                         Price = 200,
                         Image = "https://localhost:44376/StaticFiles/Images/longs1jpg.jpg",
                         Description = "need to feed family",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 6,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 1,
                         Quantity = 35,
                         Itemname = "Shorts denim pants medium",
                         Wear = "new",
                         Price = 200,
                         Image = "https://localhost:44376/StaticFiles/Images/shorts1.jfif",
                         Description = "very nice please buy",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 7,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 2,
                         Quantity = 35,
                         Itemname = "long denium jeans large",
                         Wear = "new",
                         Price = 300,
                         Image = "https://localhost:44376/StaticFiles/Images/jean2.jpg",
                         Description = "Best quality",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 8,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 2,
                         Quantity = 35,
                         Itemname = "TShirt Small",
                         Wear = "new",
                         Price = 250,
                         Image = "https://localhost:44376/StaticFiles/Images/tshirt2.jpg",
                         Description = "very good",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 9,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 2,
                         Quantity = 35,
                         Itemname = "long sleeve Polo T",
                         Wear = "new",
                         Price = 400,
                         Image = "https://localhost:44376/StaticFiles/Images/polot2.jpg",
                         Description = "give me money",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 10,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 1,
                         Quantity = 35,
                         Itemname = "long sleeve Tshirt",
                         Wear = "new",
                         Price = 200,
                         Image = "https://localhost:44376/StaticFiles/Images/longs2.jpg",
                         Description = "need to feed family",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 11,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 3,
                         Quantity = 35,
                         Itemname = "Shorts denim pants medium",
                         Wear = "new",
                         Price = 200,
                         Image = "https://localhost:44376/StaticFiles/Images/polot3.jpg",
                         Description = "very nice please buy",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 12,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 1,
                         Quantity = 35,
                         Itemname = "long denium jeans large",
                         Wear = "new",
                         Price = 300,
                         Image = "https://localhost:44376/StaticFiles/Images/jean3.jpg",
                         Description = "Best quality",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 13,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 3,
                         Quantity = 35,
                         Itemname = "TShirt Small",
                         Wear = "new",
                         Price = 250,
                         Image = "https://localhost:44376/StaticFiles/Images/tshirt3.jpg",
                         Description = "very good",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 14,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 1,
                         Quantity = 35,
                         Itemname = "long sleeve Polo T",
                         Wear = "new",
                         Price = 400,
                         Image = "https://localhost:44376/StaticFiles/Images/polot3.jpg",
                         Description = "give me money",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 15,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 3,
                         Quantity = 35,
                         Itemname = "long sleeve Tshirt",
                         Wear = "new",
                         Price = 200,
                         Image = "https://localhost:44376/StaticFiles/Images/longs3.webp",
                         Description = "need to feed family",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 16,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 2,
                         Quantity = 35,
                         Itemname = "Shorts denim pants medium",
                         Wear = "new",
                         Price = 200,
                         Image = "https://localhost:44376/StaticFiles/Images/shorts4.jfif",
                         Description = "very nice please buy",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 17,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 1,
                         Quantity = 35,
                         Itemname = "long denium jeans large",
                         Wear = "new",
                         Price = 300,
                         Image = "https://localhost:44376/StaticFiles/Images/jean4.png",
                         Description = "Best quality",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 18,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 3,
                         Quantity = 35,
                         Itemname = "TShirt Small",
                         Wear = "new",
                         Price = 250,
                         Image = "https://localhost:44376/StaticFiles/Images/tshirt4.jpg",
                         Description = "very good",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 19,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 1,
                         Quantity = 35,
                         Itemname = "long sleeve Polo T",
                         Wear = "new",
                         Price = 400,
                         Image = "https://localhost:44376/StaticFiles/Images/polot4.jpg",
                         Description = "give me money",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     },
                     new Item
                     {
                         Id = 20,
                         BrandId = 1,
                         ItemtypeId = 3,
                         //CustomerId = 2,
                         Quantity = 35,
                         Itemname = "long sleeve Tshirt",
                         Wear = "new",
                         Price = 200,
                         Image = "https://localhost:44376/StaticFiles/Images/longs4.jfif",
                         Description = "need to feed family",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     }
    );

        }
    }
}

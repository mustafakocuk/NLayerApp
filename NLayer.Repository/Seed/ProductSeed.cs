using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                Name = "Kalem1",
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now

            },
            new Product
            {
                Id = 2,
                Name = "Kalem",
                CategoryId = 1,
                Price = 200,
                Stock = 30,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 3,
                Name = "Kalem3",
                CategoryId = 1,
                Price = 400,
                Stock = 40,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 4,
                Name = "Kitap1",
                CategoryId = 2,
                Price = 40,
                Stock = 40,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 5,
                Name = "Kitap2",
                CategoryId = 2,
                Price = 400,
                Stock = 70,
                CreatedDate = DateTime.Now
            });
        }
    }
}

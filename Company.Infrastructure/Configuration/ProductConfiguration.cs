using Company.Core.Models.Blog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Company.Core.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infrastructure.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
            new Product
            {
                ProductId = new Guid("90abbca8-664d-4b20-b5de-024705497d4a"),
                ProductImageUrl = "IMAGE URL",
                Name = "583 Wall Dr. Gwynn Oak, MD 21207",
                Description = "Re",
                Price = 100,
                StockQuantity = 50,


            },
            new Product
            {
                ProductId = new Guid("91abbca8-664d-4b20-b5de-024705497d4a"),
                ProductImageUrl = "IMAGE URL",
                Name = "583 Wall Dr. Gwynn Oak, MD 21207",
                Description = "Product 2 description",
                Price = 1000,
                StockQuantity = 50,
            },
            new Product { 
                ProductId = new Guid("92abbca8-664d-4b20-b5de-024705497d4a"),
                ProductImageUrl = "IMAGE URL",
                Name = "product 3",
                Description = "product 3 description",
                Price = 100,
                StockQuantity = 500,
            }

            );
        }
    }
}

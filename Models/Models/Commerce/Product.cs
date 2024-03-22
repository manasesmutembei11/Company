using Company.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.Commerce
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string? ProductImageUrl { get; set; }

        public Category? Category { get; set; }
    }
}
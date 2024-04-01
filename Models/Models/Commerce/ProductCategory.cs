using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.Commerce
{
    public class ProductCategory
    {
        public Guid ProductCategoryId { get; set; }

        public int ProductCategoryCode { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Product>? Products { get; set; }


    }
}

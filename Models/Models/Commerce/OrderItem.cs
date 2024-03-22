using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.Commerce
{
    public class OrderItem
    {
        public Guid OrderItemId { get; set; }

        public int OrderCode { get; set; }

        public Product? Product { get; set; }

        public int OrderQuantity { get; set; }

        public decimal OrderPrice { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.Commerce
{
    public class ShoppingCart
    {
        public Guid ShoppingCartId { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }

        public int TotalItems { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
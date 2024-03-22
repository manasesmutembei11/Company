using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.Commerce
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public decimal TotalAmount { get; set; }

        public ShippingAddress? ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
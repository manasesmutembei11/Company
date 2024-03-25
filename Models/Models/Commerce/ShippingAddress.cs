using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Company.Core.Models.UserInfo;

namespace Company.Core.Models.Commerce
{
    public class ShippingAddress
    {
        public Guid ShippingAddressId { get; set; }
        public string? Country { get; set; }
        public string? Street {  get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public string? PostalCode { get; set; }

       
        
    }
}

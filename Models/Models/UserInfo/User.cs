using Company.Core.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.UserInfo
{
    public class User
    {
        public Guid UserId { get; set; }

        public string? UserProfileUrl { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public string? PhoneNumber { get; set; }

        public ShippingAddress? ShippingAddress { get; set; }

        public ICollection<UserRole>? UserRole { get; set; }
    }
}
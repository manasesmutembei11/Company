using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core.Models.UserInfo
{
    public class Permission
    {
        public Guid PermissionId { get; set; }

        public string? PermissionCode { get; set; }

        public string? PermissionName { get; set; }

        public string? Description { get; set; }
    }
}
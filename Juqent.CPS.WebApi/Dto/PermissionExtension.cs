using System;
using System.Collections.Generic;
using System.Text;

namespace Juqent.CPS.WebApi
{
    public class PermissionExtension
    {
        public string PermissionCode { get; set; }

        public string PermissionName { get; set; }

        public List<PermissionExtension> ChildPermissions { get; set; }
    }
}

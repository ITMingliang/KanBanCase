using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi
{
    public class AbpUserDto
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public int TenantId { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string WeChat { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public string DepartName { get; set; }
        public string Password { get; set; }
    }
}
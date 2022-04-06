using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi
{
  public  class LoginUserInfoDto
    {
        public string TenancyName { get; set; }
        public string UsernameOrEmailAddress { get; set; }
        public string Password { get; set; }
        public int DeviceType { get; set; }
        public string Mac { get; set; }
    }
}

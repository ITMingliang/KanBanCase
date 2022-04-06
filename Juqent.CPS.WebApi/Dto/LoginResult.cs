using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Juqent.CPS.WebApi
{
    [Serializable]
    public class LoginResultModel
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public OrganizationUnits CurrentOrgUnit { get; set; }
        public string Token { get; set; }
        public PermissionExtension GrantPermission { get; set; }
        public List<OrganizationUnits> OrgUnits { get; set; }
    }

    [Serializable]
    public class Permissions
    {
        public string PermissionCode { get; set; }
        public string PermissionName { get; set; }
        public List<Permissions> ChildPermissions { get; set; }
    }

    [Serializable]
    public class OrganizationUnits
    {
        public long? ParentId { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }
        public int MemberCount { get; set; }
        public OrganizationUnits Parent { get; set; }
    }
}
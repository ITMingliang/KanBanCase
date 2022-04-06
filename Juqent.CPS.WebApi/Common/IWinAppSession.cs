using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi
{
    public interface IWinAppSession
    {
        /// <summary>
        /// Gets current UserId or null.
        /// It can be null if no user logged in.
        /// </summary>
        long? UserId { get; set; }

        /// <summary>
        /// Get user Codes
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// Get User FullName
        /// </summary>
        string FullName { get; set; }

        /// <summary>
        /// Gets current TenantId or null.
        /// This TenantId should be the TenantId of the <see cref="UserId"/>.
        /// It can be null if given <see cref="UserId"/> is a host user or no user logged in.
        /// </summary>
        int? TenantId { get; set; }

        /// <summary>
        /// AccessToken when User Is Logined
        /// </summary>
        string AccessToken { get; set; }

        /// <summary>
        /// OrgId when User is Logined
        /// </summary>
        long? OrgId { get; set; }

        /// <summary>
        /// Current OrgId for the logined User
        /// </summary>
        OrganizationUnits CurrentOrgUnit { get; set; }

        /// <summary>
        /// All the OrgUnits for the logined User
        /// </summary>
        List<OrganizationUnits> OrgUnits { get; set; }

        /// <summary>
        /// GrantPermission for the logined User ,For the Tree Struct
        /// </summary>
        PermissionExtension GrantPermission { get; set; }

        /// <summary>
        /// Grant Permission for List Struct
        /// </summary>
        List<PermissionExtension> GrantPermissionList { get; set; }
    }
}

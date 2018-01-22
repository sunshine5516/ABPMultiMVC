using System.Collections.Generic;
using ABPMultiMVC.Roles.Dto;

namespace ABPMultiMVC.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
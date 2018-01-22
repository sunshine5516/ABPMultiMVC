using System.Collections.Generic;
using ABPMultiMVC.Roles.Dto;
using ABPMultiMVC.Users.Dto;

namespace ABPMultiMVC.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
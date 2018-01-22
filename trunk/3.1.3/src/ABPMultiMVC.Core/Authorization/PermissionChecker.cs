using Abp.Authorization;
using ABPMultiMVC.Authorization.Roles;
using ABPMultiMVC.Authorization.Users;

namespace ABPMultiMVC.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

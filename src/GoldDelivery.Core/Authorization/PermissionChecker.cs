using Abp.Authorization;
using GoldDelivery.Authorization.Roles;
using GoldDelivery.Authorization.Users;

namespace GoldDelivery.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

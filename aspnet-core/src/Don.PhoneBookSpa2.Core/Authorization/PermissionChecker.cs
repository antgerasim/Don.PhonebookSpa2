using Abp.Authorization;
using Don.PhoneBookSpa2.Authorization.Roles;
using Don.PhoneBookSpa2.Authorization.Users;

namespace Don.PhoneBookSpa2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

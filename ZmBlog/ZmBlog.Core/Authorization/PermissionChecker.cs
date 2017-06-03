using Abp.Authorization;
using ZmBlog.Authorization.Roles;
using ZmBlog.MultiTenancy;
using ZmBlog.Users;

namespace ZmBlog.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

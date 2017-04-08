using Abp.Authorization;
using ProyetoSmarterAudit.Authorization.Roles;
using ProyetoSmarterAudit.MultiTenancy;
using ProyetoSmarterAudit.Users;

namespace ProyetoSmarterAudit.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

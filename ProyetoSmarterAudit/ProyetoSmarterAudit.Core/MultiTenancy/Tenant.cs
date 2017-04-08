using Abp.MultiTenancy;
using ProyetoSmarterAudit.Users;

namespace ProyetoSmarterAudit.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
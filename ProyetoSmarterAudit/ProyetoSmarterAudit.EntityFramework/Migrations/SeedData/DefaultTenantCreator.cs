using System.Linq;
using ProyetoSmarterAudit.EntityFramework;
using ProyetoSmarterAudit.MultiTenancy;

namespace ProyetoSmarterAudit.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ProyetoSmarterAuditDbContext _context;

        public DefaultTenantCreator(ProyetoSmarterAuditDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

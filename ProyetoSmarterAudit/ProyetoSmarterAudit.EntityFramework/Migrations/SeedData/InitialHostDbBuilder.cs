using ProyetoSmarterAudit.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ProyetoSmarterAudit.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ProyetoSmarterAuditDbContext _context;

        public InitialHostDbBuilder(ProyetoSmarterAuditDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

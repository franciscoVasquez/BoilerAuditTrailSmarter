using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ProyetoSmarterAudit.EntityFramework;

namespace ProyetoSmarterAudit.Migrator
{
    [DependsOn(typeof(ProyetoSmarterAuditDataModule))]
    public class ProyetoSmarterAuditMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ProyetoSmarterAuditDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
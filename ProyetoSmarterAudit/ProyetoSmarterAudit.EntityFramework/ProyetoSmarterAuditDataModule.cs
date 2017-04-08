using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ProyetoSmarterAudit.EntityFramework;

namespace ProyetoSmarterAudit
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ProyetoSmarterAuditCoreModule))]
    public class ProyetoSmarterAuditDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ProyetoSmarterAuditDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

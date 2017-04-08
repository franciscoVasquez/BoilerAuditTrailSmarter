using Abp.Modules;
using Abp.MultiTenancy;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Castle.MicroKernel.Registration;
using NSubstitute;

namespace ProyetoSmarterAudit.Tests
{
    [DependsOn(
        typeof(ProyetoSmarterAuditApplicationModule),
        typeof(ProyetoSmarterAuditDataModule),
        typeof(AbpTestBaseModule))]
    public class ProyetoSmarterAuditTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Registering fake services

            IocManager.IocContainer.Register(
                Component.For<IAbpZeroDbMigrator>()
                    .UsingFactoryMethod(() => Substitute.For<IAbpZeroDbMigrator>())
                    .LifestyleSingleton()
                );
        }
    }
}

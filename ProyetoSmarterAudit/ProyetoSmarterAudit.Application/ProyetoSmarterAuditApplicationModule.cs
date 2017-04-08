using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace ProyetoSmarterAudit
{
    [DependsOn(typeof(ProyetoSmarterAuditCoreModule), typeof(AbpAutoMapperModule))]
    public class ProyetoSmarterAuditApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

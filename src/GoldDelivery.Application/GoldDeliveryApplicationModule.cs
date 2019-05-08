using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GoldDelivery.Authorization;

namespace GoldDelivery
{
    [DependsOn(
        typeof(GoldDeliveryCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GoldDeliveryApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GoldDeliveryAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GoldDeliveryApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

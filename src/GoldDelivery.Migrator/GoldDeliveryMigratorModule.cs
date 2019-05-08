using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GoldDelivery.Configuration;
using GoldDelivery.EntityFrameworkCore;
using GoldDelivery.Migrator.DependencyInjection;

namespace GoldDelivery.Migrator
{
    [DependsOn(typeof(GoldDeliveryEntityFrameworkModule))]
    public class GoldDeliveryMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public GoldDeliveryMigratorModule(GoldDeliveryEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(GoldDeliveryMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                GoldDeliveryConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GoldDeliveryMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}

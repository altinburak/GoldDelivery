using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GoldDelivery.Configuration;

namespace GoldDelivery.Web.Host.Startup
{
    [DependsOn(
       typeof(GoldDeliveryWebCoreModule))]
    public class GoldDeliveryWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GoldDeliveryWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GoldDeliveryWebHostModule).GetAssembly());
        }
    }
}

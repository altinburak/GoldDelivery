using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GoldDelivery.Configuration;
using GoldDelivery.Web;

namespace GoldDelivery.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GoldDeliveryDbContextFactory : IDesignTimeDbContextFactory<GoldDeliveryDbContext>
    {
        public GoldDeliveryDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GoldDeliveryDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GoldDeliveryDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GoldDeliveryConsts.ConnectionStringName));

            return new GoldDeliveryDbContext(builder.Options);
        }
    }
}

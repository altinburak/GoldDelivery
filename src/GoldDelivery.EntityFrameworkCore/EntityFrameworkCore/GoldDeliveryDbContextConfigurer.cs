using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GoldDelivery.EntityFrameworkCore
{
    public static class GoldDeliveryDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GoldDeliveryDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GoldDeliveryDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

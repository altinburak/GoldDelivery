using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GoldDelivery.Authorization.Roles;
using GoldDelivery.Authorization.Users;
using GoldDelivery.MultiTenancy;

namespace GoldDelivery.EntityFrameworkCore
{
    public class GoldDeliveryDbContext : AbpZeroDbContext<Tenant, Role, User, GoldDeliveryDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GoldDeliveryDbContext(DbContextOptions<GoldDeliveryDbContext> options)
            : base(options)
        {
        }
    }
}

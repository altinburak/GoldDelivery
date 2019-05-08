using System.Threading.Tasks;
using Abp.Application.Services;
using GoldDelivery.Authorization.Accounts.Dto;

namespace GoldDelivery.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

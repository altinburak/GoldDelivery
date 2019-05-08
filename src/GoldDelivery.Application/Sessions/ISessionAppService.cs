using System.Threading.Tasks;
using Abp.Application.Services;
using GoldDelivery.Sessions.Dto;

namespace GoldDelivery.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

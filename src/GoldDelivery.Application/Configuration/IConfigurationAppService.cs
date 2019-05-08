using System.Threading.Tasks;
using GoldDelivery.Configuration.Dto;

namespace GoldDelivery.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

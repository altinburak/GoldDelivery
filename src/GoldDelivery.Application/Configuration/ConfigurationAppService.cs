using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GoldDelivery.Configuration.Dto;

namespace GoldDelivery.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GoldDeliveryAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

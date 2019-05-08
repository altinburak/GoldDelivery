using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GoldDelivery.Controllers
{
    public abstract class GoldDeliveryControllerBase: AbpController
    {
        protected GoldDeliveryControllerBase()
        {
            LocalizationSourceName = GoldDeliveryConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

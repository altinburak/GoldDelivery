using Microsoft.AspNetCore.Antiforgery;
using GoldDelivery.Controllers;

namespace GoldDelivery.Web.Host.Controllers
{
    public class AntiForgeryController : GoldDeliveryControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

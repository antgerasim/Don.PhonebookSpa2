using Don.PhoneBookSpa2.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Don.PhoneBookSpa2.Web.Host.Controllers
{
    public class AntiForgeryController : PhoneBookSpa2ControllerBase
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
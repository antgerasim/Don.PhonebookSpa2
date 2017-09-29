using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Don.PhoneBookSpa2.Controllers
{
    public abstract class PhoneBookSpa2ControllerBase: AbpController
    {
        protected PhoneBookSpa2ControllerBase()
        {
            LocalizationSourceName = PhoneBookSpa2Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
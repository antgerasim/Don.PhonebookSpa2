using System.Collections.Generic;

namespace Don.PhoneBookSpa2.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}

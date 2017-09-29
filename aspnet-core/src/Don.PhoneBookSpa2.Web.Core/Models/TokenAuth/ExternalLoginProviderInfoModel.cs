using Abp.AutoMapper;
using Don.PhoneBookSpa2.Authentication.External;

namespace Don.PhoneBookSpa2.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}

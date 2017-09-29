using System.Threading.Tasks;
using Don.PhoneBookSpa2.Configuration.Dto;

namespace Don.PhoneBookSpa2.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
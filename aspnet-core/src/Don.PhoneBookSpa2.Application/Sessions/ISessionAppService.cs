using System.Threading.Tasks;
using Abp.Application.Services;
using Don.PhoneBookSpa2.Sessions.Dto;

namespace Don.PhoneBookSpa2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

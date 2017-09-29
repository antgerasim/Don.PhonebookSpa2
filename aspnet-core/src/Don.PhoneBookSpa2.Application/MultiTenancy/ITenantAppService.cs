using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Don.PhoneBookSpa2.MultiTenancy.Dto;

namespace Don.PhoneBookSpa2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

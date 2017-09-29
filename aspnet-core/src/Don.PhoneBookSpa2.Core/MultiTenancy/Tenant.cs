using Abp.MultiTenancy;
using Don.PhoneBookSpa2.Authorization.Users;

namespace Don.PhoneBookSpa2.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
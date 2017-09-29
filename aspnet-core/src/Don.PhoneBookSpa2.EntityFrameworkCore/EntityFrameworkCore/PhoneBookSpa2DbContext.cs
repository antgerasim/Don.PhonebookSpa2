using Abp.Zero.EntityFrameworkCore;
using Don.PhoneBookSpa2.Authorization.Roles;
using Don.PhoneBookSpa2.Authorization.Users;
using Don.PhoneBookSpa2.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Don.PhoneBookSpa2.EntityFrameworkCore
{
    public class PhoneBookSpa2DbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookSpa2DbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public PhoneBookSpa2DbContext(DbContextOptions<PhoneBookSpa2DbContext> options)
            : base(options)
        {

        }
    }
}

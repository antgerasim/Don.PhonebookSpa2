using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Don.PhoneBookSpa2.Localization;
using Abp.Zero.Configuration;
using Don.PhoneBookSpa2.MultiTenancy;
using Don.PhoneBookSpa2.Authorization.Roles;
using Don.PhoneBookSpa2.Authorization.Users;
using Don.PhoneBookSpa2.Configuration;
using Don.PhoneBookSpa2.Timing;

namespace Don.PhoneBookSpa2
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class PhoneBookSpa2CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            PhoneBookSpa2LocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = PhoneBookSpa2Consts.MultiTenancyEnabled;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookSpa2CoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
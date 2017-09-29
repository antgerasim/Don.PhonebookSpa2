using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.PhoneBookSpa2.Authorization;

namespace Don.PhoneBookSpa2
{
    [DependsOn(
        typeof(PhoneBookSpa2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhoneBookSpa2ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhoneBookSpa2AuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(PhoneBookSpa2ApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
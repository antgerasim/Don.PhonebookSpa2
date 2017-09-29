using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.PhoneBookSpa2.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Don.PhoneBookSpa2.Web.Host.Startup
{
    [DependsOn(
       typeof(PhoneBookSpa2WebCoreModule))]
    public class PhoneBookSpa2WebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhoneBookSpa2WebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookSpa2WebHostModule).GetAssembly());
        }
    }
}

using Don.PhoneBookSpa2.Configuration;
using Don.PhoneBookSpa2.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Don.PhoneBookSpa2.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoneBookSpa2DbContextFactory : IDesignTimeDbContextFactory<PhoneBookSpa2DbContext>
    {
        public PhoneBookSpa2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookSpa2DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoneBookSpa2DbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoneBookSpa2Consts.ConnectionStringName));

            return new PhoneBookSpa2DbContext(builder.Options);
        }
    }
}
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Don.PhoneBookSpa2.EntityFrameworkCore
{
    public static class PhoneBookSpa2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneBookSpa2DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PhoneBookSpa2DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
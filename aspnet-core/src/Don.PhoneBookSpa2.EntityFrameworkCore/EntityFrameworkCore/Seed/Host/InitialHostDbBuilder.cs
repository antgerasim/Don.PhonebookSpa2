using Don.PhoneBookSpa2.EntityFrameworkCore.Seed.Domain.People;

namespace Don.PhoneBookSpa2.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly PhoneBookSpa2DbContext _context;

        public InitialHostDbBuilder(PhoneBookSpa2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            //Default domain seed 
            new DefaultPersonCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}

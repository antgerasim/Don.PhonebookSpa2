using System.Linq;
using Don.PhoneBookSpa2.Domain.People;
using Microsoft.EntityFrameworkCore;

namespace Don.PhoneBookSpa2.EntityFrameworkCore.Seed.Domain.People
{
    public class DefaultPersonCreator
    {
        private readonly PhoneBookSpa2DbContext _context;

        public DefaultPersonCreator(PhoneBookSpa2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultPersons();
        }

        private void CreateDefaultPersons()
        {
            var douglas = _context.Persons.FirstOrDefault(p => p.EmailAddress == "douglas.adams@fortytwo.com");
            if (douglas == null)
            {
                _context.Persons.Add(new Person()
                {
                    Name = "Douglas",
                    Surname = "Adams",
                    EmailAddress = "douglas.adams@fortytwo.com"
                });
            }

            var asimov = _context.Persons.FirstOrDefault(p => p.EmailAddress == "isaac.asimov@foundation.org");
            if (asimov == null)
            {
                _context.Persons.Add(new Person()
                {
                    Name = "Isaac",
                    Surname = "Asimov",
                    EmailAddress = "isaac.asimov@foundation.org"
                });
            }
        }
    }
}
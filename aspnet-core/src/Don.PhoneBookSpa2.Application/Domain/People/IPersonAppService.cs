using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Castle.Core.Internal;
using Don.PhoneBookSpa2.Domain.People.Dto;

namespace Don.PhoneBookSpa2.Domain.People
{
    public interface IPersonAppService : IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
    }

    public class PersonAppService : PhoneBookSpa2AppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public ListResultDto<PersonListDto> GetPeople(GetPeopleInput input)
        {
            var people = _personRepository.GetAll().WhereIf(!input.Filter.IsNullOrEmpty(),
                p => p.Name.Contains(input.Filter) || p.Surname.Contains(input.Filter) ||
                     p.EmailAddress.Contains(input.Filter)).OrderBy(p=>p.Name).ThenBy(p=>p.Surname).ToList();

            var personReadOnlyList = ObjectMapper.Map<List<PersonListDto>>(people);
            var retVal = new ListResultDto<PersonListDto>(personReadOnlyList);
            return retVal;
        }
    }
}
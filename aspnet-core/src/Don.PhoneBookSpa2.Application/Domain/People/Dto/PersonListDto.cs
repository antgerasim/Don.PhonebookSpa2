using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Don.PhoneBookSpa2.Domain.People.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : FullAuditedEntityDto
    {
        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual string EmailAddress { get; set; }
    }
}
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HS.Farm.People.Dtos;

namespace HS.Farm.People
{
    public class PersonAppService : CrudAppService<Person, PersonDto>, Farm.People.IPersonAppService//IPersonAppService //Optionally, you can derive from ApplicationService as we did for TaskAppService class.
    {
        private readonly IRepository<Person> _personRepository;
        //ABP provides that we can directly inject IRepository<Person> (without creating any repository class)
        public PersonAppService(IRepository<Person> personRepository):base(personRepository)
        {
            _personRepository = personRepository;
        }
        //protected override Person GetEntityById(int id)
        //{
        //    return base.GetEntityById(id);
        //}
        ////This method uses async pattern that is supported by ASP.NET Boilerplate
        //public async Task<GetAllPeopleOutput> GetAllPeople()
        //{
        //    var people = await _personRepository.GetAllListAsync();
        //    return new GetAllPeopleOutput
        //    {
        //        People = people.MapTo<List<PersonDto>>()
        //    };
        //}
    }
}

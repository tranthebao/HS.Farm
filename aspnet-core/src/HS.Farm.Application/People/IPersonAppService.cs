using Abp.Application.Services;
using HS.Farm.People.Dtos;

namespace HS.Farm.People
{
    public interface IPersonAppService : ICrudAppService<PersonDto>//IApplicationService
    {
        //Task<GetAllPeopleOutput> GetAllPeople();
    }
}

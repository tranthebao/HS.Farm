using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    [AbpAuthorize]
    //[AbpAllowAnonymous]
    public class CayTrongAppService : CrudAppService<CayTrong, CayTrongDto>, ICayTrongAppService
    {
        //private readonly IRepository<CayTrong> _repository;
        public CayTrongAppService(IRepository<CayTrong> repository) : base(repository)
        {
            //_repository = repository;
        }
    }
}

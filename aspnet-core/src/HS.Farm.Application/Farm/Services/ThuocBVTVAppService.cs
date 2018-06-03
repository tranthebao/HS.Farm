using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ThuocBVTVAppService : CrudAppService<ThuocBVTV, ThuocBVTVDto>, IThuocBVTVAppService
    {
        private readonly IRepository<ThuocBVTV> _repository;
        public ThuocBVTVAppService(IRepository<ThuocBVTV> repository)
             : base(repository)
        {
            _repository = repository;
        }
    }
}

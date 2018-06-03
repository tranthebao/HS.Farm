using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChiTietThuChiAppService : CrudAppService<ThuChi, ThuChiDto>, IThuChiAppService
    {
        private readonly IRepository<ThuChi> _repository;
        public ChiTietThuChiAppService(IRepository<ThuChi> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}

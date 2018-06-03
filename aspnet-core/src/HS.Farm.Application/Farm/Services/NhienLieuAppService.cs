using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class NhienLieuAppService : CrudAppService<NhienLieu, NhienLieuDto>, INhienLieuAppService
    {
        private readonly IRepository<NhienLieu> _repository;
        public NhienLieuAppService(IRepository<NhienLieu> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}

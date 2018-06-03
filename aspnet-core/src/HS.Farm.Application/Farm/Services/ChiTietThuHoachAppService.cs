using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChiTietThuHoachAppService : CrudAppService<ChiTietThuHoach, ChiTietThuHoachDto>, IChiTietThuHoachAppService
    {
        private readonly IRepository<ChiTietThuHoach> _repository;
        public ChiTietThuHoachAppService(IRepository<ChiTietThuHoach> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}

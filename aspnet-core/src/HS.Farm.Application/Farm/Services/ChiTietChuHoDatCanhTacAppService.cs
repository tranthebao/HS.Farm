using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChiTietChuHoDatCanhTacAppService : CrudAppService<ChiTietChuHoDatCanhTac, ChiTietChuHoDatCanhTacDto>, IChiTietChuHoDatCanhTacAppService
    {
        private readonly IRepository<ChiTietChuHoDatCanhTac> _repository;
        public ChiTietChuHoDatCanhTacAppService(IRepository<ChiTietChuHoDatCanhTac> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}

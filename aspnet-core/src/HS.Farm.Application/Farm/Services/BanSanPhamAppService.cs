using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class BanSanPhamAppService : CrudAppService<BanSanPham, BanSanPhamDto>, IBanSanPhamAppService
    {
        private readonly IRepository<BanSanPham> _repository;
        public BanSanPhamAppService(IRepository<BanSanPham> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}

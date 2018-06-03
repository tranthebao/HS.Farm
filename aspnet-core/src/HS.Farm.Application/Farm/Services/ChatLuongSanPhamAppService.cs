using Abp.Application.Services;
using Abp.Domain.Repositories;
using HS.Farm.Application.Dto;
using HS.Farm.Application.Interfaces;
using HS.Farm.Core;

namespace HS.Farm.Application.Services
{
    public class ChatLuongSanPhamAppService : CrudAppService<ChatLuongSanPham, ChatLuongSanPhamDto>, IChatLuongSanPhamAppService
    {
        private readonly IRepository<ChatLuongSanPham> _repository;
        public ChatLuongSanPhamAppService(IRepository<ChatLuongSanPham> repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}

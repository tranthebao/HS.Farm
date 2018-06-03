using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HS.Farm.Core
{
    [Table("AbpChatLuongSanPham")]
    public class ChatLuongSanPham: FullAuditedEntity, IMayHaveTenant
    {
        [Required]
        public virtual float DoDzem { get; set; }
        [Required]
        public virtual float TapChat { get; set; }
        [Required]
        public virtual float DoAm { get; set; }
        public virtual int? TenantId { get; set; }
    }
}

using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HS.Farm.Core
{
    [Table("AbpLaoDongThueNgoai")]
    public class LaoDongThueNgoai: FullAuditedEntity, IMayHaveTenant
    {
        [MaxLength(50)]
        [Required]
        public virtual string HoTenNhanCong { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string CMND { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string DiaChi { get; set; }
        [MaxLength(50)]
        [Required]
        public virtual string GioiTinh { get; set; }
        [Required]
        public virtual DateTime NgaySinh { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        [Required]
        public virtual DateTime NgayBatDau { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/dd/MM}")]
        [Required]
        public virtual DateTime NgayNgayKetThuc { get; set; }
        public virtual int CongId { get; set; }
        public virtual Cong Cong { get; set;}
        public virtual int? TenantId { get; set; }
    }
}

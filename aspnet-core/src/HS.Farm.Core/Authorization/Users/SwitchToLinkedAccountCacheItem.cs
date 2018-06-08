using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Farm.Authorization.Users
{
    [Serializable]
    public class SwitchToLinkedAccountCacheItem
    {
        public const string CacheName = "AppSwitchToLinkedAccountCache";

        public int? TargetTenantId { get; set; }

        public long TargetUserId { get; set; }

        public int? ImpersonatorTenantId { get; set; }

        public long? ImpersonatorUserId { get; set; }

        public SwitchToLinkedAccountCacheItem()
        {

        }

        public SwitchToLinkedAccountCacheItem(
            int? targetTenantId,
            long targetUserId,
            int? impersonatorTenantId,
            long? impersonatorUserId
            )
        {
            TargetTenantId = targetTenantId;
            TargetUserId = targetUserId;
            ImpersonatorTenantId = impersonatorTenantId;
            ImpersonatorUserId = impersonatorUserId;
        }
    }
}

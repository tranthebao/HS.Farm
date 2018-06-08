using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Farm.Authorization.Users
{
    public static class SwitchToLinkedAccountCacheManagerExtensions
    {
        public static ITypedCache<string, SwitchToLinkedAccountCacheItem> GetSwitchToLinkedAccountCache(this ICacheManager cacheManager)
        {
            return cacheManager.GetCache<string, SwitchToLinkedAccountCacheItem>(SwitchToLinkedAccountCacheItem.CacheName);
        }
    }
}

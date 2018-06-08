using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Farm.Authorization.Impersonation
{
    public static class ImpersonationCacheManagerExtensions
    {
        public static ITypedCache<string, ImpersonationCacheItem> GetImpersonationCache(this ICacheManager cacheManager)
        {
            return cacheManager.GetCache<string, ImpersonationCacheItem>(ImpersonationCacheItem.CacheName);
        }
    }
}

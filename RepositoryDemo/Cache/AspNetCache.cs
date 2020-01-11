using System;
using System.Web;

namespace RepositoryDemo.Cache
{
    public class AspNetCache : ICache
    {
        public T Get<T>(string cacheKey)
        {
            return (T)HttpRuntime.Cache.Get(cacheKey);
        }

        public void Set<T>(string cacheKey, T obj)
        {
            HttpRuntime.Cache.Insert(cacheKey, obj, null, DateTime.Now.AddSeconds(60), TimeSpan.Zero);
        }
    }
}

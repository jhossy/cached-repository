namespace RepositoryDemo.Cache
{
    public interface ICache
    {
        T Get<T>(string cacheKey);

        void Set<T>(string cacheKey, T obj);
    }
}

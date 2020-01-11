using RepositoryDemo.Cache;
using System;

namespace RepositoryDemo.Entities
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ICache _cache;

        public AccountRepository(ICache accountCache)
        {
            _cache = accountCache;
        }

        public Account FindById(int id)
        {
            string cacheKey = $"account_{id}";

            Account result = _cache.Get<Account>(cacheKey);

            if (result != null)
            {
                Console.WriteLine("Getting from cache...");
                return result;
            }

            Console.WriteLine("Getting from db...");

            result = new Account(5); //get from datasource logic here

            _cache.Set(cacheKey, result);

            return result;
        }
    }
}

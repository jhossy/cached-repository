using RepositoryDemo.Cache;
using RepositoryDemo.Entities;
using System;

namespace RepositoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICache cache = new AspNetCache();
            IAccountRepository _accountRepository = new AccountRepository(cache);

            Account account;

            for (int i = 0; i < 10; i++)
            {
                account = _accountRepository.FindById(5);
            }

            Console.ReadLine();
        }
    }
}

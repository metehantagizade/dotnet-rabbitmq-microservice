using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Data.Context
{
    public class Seed
    {
        public static void SeedData(BankingDbContext context)
        {
            if (context.Accounts.Any()) return;

            var accounts = new List<Account>
            {
                new Account
                {
                    AccountType = "Checking",
                    AccountBalance = 0,
                    Id = 1
                },
                new Account
                {
                    AccountType = "Saving",
                    AccountBalance = 0,
                    Id = 2
                }
            };
            context.Accounts.AddRange(accounts);
            context.SaveChanges();
        }
    }
}

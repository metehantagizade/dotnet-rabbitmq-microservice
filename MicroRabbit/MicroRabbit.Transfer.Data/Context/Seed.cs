using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MicroRabbit.Transfer.Data.Context
{
    public class Seed
    {
        public static void SeedData(TransferDbContext context)
        {
            if (context.TransferLogs.Any()) return;

            var transferLogs = new List<TransferLog>
            {
                new TransferLog
                {
                    Id = 1,
                    Amount = 5,
                    FromAccount = 1,
                    ToAccount = 2,
                },
                new TransferLog
                {
                    Id = 2,
                    Amount = 10,
                    FromAccount = 1,
                    ToAccount = 2
                }
            };
            context.TransferLogs.AddRange(transferLogs);
            context.SaveChanges();
        }
    }
}

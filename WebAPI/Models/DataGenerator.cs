using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using WebAPI.DataContext;

namespace WebAPI.Models
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AccountDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AccountDbContext>>()))
            {
                if (context.Account.Any())
                {
                    return;   
                }

                context.Account.AddRange(
                    new Account
                    {
                        IdAccount = 1,
                        AccountNumber = BigInteger.Parse("02116022020000000333333333"),
                        AccountName = "personal account",
                        AvailableFunds = 222.0m,
                        Blance = 300.0m,
                        IsCard = true
                    },
                    new Account
                    {
                        IdAccount = 2,
                        AccountNumber = BigInteger.Parse("02116022020000000337777777"),
                        AccountName = "currency account",
                        AvailableFunds = 1222.0m,
                        Blance = 1300.0m,
                        IsCard = true
                    },
                    new Account
                    {
                        IdAccount = 3,
                        AccountNumber = BigInteger.Parse("02116022020000000337888888"),
                        AccountName = "currency account",
                        AvailableFunds = 2222.0m,
                        Blance = 2300.0m,
                        IsCard = false
                    });

                context.SaveChanges();
            }
        }
    }
}

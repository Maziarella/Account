using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DataContext
{
    public class AccountDbContext : DbContext
    {

       
            public AccountDbContext(DbContextOptions<AccountDbContext> options)
                : base(options)
            {
            }

            public DbSet<Models.Account> Account { get; set; }
    }
}

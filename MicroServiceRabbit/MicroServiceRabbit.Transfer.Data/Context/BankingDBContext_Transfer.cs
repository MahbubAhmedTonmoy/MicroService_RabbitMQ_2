using MicroServiceRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Transfer.Data.Context
{
    public class BankingDBContext_Transfer: DbContext
    {
        public BankingDBContext_Transfer(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TransferLog> Accounts { get; set; }
    }
}

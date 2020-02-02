using MicroServiceRabbit.Banking.Data.Context;
using MicroServiceRabbit.Banking.Domain.Interfaces;
using MicroServiceRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDBContext _context;

        public AccountRepository(BankingDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }

        
    }
}

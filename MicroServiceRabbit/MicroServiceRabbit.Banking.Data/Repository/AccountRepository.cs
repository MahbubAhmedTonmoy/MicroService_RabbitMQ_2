using MicroServiceRabbit.Banking.Data.Context;
using MicroServiceRabbit.Banking.Domain.Interfaces;
using MicroServiceRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroServiceRabbit.Banking.Data.Repository
{
    class AccountRepository : IAccountRepository
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

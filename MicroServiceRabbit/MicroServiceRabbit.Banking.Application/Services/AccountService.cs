using MicroServiceRabbit.Banking.Application.Interfaces;
using MicroServiceRabbit.Banking.Domain.Interfaces;
using MicroServiceRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;
        public AccountService(IAccountRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<Account> GetAccounts()
        {
            throw new NotImplementedException();
        }
    }
}

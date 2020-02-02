using MicroServiceRabbit.Banking.Application.DTO;
using MicroServiceRabbit.Banking.Application.Interfaces;
using MicroServiceRabbit.Banking.Domain.Commands;
using MicroServiceRabbit.Banking.Domain.Interfaces;
using MicroServiceRabbit.Banking.Domain.Models;
using MicroServiceRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository repo, IEventBus bus)
        {
            _repo = repo;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _repo.GetAccounts();
        }

        public void Transfer(TransferAmmount ta)
        {
            // command create -- domain e command class ache
            var createTransferCommand = new CreateTransferCommand(ta.FromAccount, ta.TOAccount, ta.Balence);

            // use bus send command
            _bus.SandCommand(createTransferCommand);
        } 
    }
}

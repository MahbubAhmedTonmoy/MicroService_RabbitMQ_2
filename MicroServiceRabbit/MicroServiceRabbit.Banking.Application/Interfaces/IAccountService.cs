using MicroServiceRabbit.Banking.Application.DTO;
using MicroServiceRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(TransferAmmount ta);
    }
}

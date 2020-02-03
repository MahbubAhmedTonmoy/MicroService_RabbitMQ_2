using MicroServiceRabbit.Transfer.Data.Context;
using MicroServiceRabbit.Transfer.Domain.Interfaces;
using MicroServiceRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Transfer.Data.Repository
{
    public class TransferRepositoy: ITransferRepositoy
    {
        private readonly BankingDBContext_Transfer _context;
        public TransferRepositoy(BankingDBContext_Transfer context)
        {
            _context = context;
        }
        public IEnumerable<TransferLog> GetTansferLogs()
        {
            return _context.Accounts;
        }
    }
}

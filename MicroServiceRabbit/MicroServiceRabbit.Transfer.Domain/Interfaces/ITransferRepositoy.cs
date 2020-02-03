using MicroServiceRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepositoy
    {
        IEnumerable<TransferLog> GetTansferLogs();
        void Add(TransferLog transferLog);
    }
}

using MicroServiceRabbit.Domain.Core.Bus;
using MicroServiceRabbit.Transfer.Application.Interfaces;
using MicroServiceRabbit.Transfer.Data.Repository;
using MicroServiceRabbit.Transfer.Domain.Interfaces;
using MicroServiceRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepositoy _repo;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepositoy repo,IEventBus bus)
        {
            _repo = repo;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTansferLogs()
        {
            return _repo.GetTansferLogs();
        }
    }
}

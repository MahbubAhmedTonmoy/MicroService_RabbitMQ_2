using MicroServiceRabbit.Domain.Core.Bus;
using MicroServiceRabbit.Transfer.Domain.Events;
using MicroServiceRabbit.Transfer.Domain.Interfaces;
using MicroServiceRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepositoy _repo;
        public TransferEventHandler(ITransferRepositoy repo)
        {
            //inject bus send more command -> notification
            _repo = repo;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _repo.Add(new TransferLog()
            {
                FromAccount = @event.Form,
                ToAccount = @event.To,
                TransferAmmount = @event.Ammount
            });
            return Task.CompletedTask;
        }
    }
}

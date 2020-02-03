using MicroServiceRabbit.Domain.Core.Bus;
using MicroServiceRabbit.Transfer.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroServiceRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
            //inject bus send more command -> notification
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}

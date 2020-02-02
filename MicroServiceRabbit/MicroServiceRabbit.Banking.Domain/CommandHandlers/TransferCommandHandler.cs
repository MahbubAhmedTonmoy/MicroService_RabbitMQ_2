using MediatR;
using MicroServiceRabbit.Banking.Domain.Commands;
using MicroServiceRabbit.Banking.Domain.Events;
using MicroServiceRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceRabbit.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {

            //publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.Form, request.To,request.Ammount));

            return Task.FromResult(true);
        }
    }
}

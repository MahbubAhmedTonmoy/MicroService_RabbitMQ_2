using System.Threading.Tasks;
using MicroServiceRabbit.Domain.Core.Events;

namespace MicroServiceRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent: Event
    {
        Task Handle(TEvent @event);    
    }
    public interface IEventHandler
    {
         
    }
}
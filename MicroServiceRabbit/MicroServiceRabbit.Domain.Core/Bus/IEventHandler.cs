using System.Threading.Tasks;
using MicroServiceRabbit.Domain.Core.Events;

namespace MicroServiceRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent: Event  // <in TEvent> takes in any type of event
    {
        Task Handle(TEvent @event);    
    }
    public interface IEventHandler
    {
         
    }
}

//ref vs in vs out

//    ref : may b modified 
//    in : not modified
//    out: must modified
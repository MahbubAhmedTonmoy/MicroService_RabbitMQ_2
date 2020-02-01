using System.Threading.Tasks;
using MicroServiceRabbit.Domain.Core.Commands;
using MicroServiceRabbit.Domain.Core.Events;

namespace MicroServiceRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
         Task SandCommand<T> (T command) where T : Command;
         void Publish<T>(T @event) where T : Event;
         void Subscriber<T, TH>()
             where T: Event 
             where TH: IEventHandler<T>;
    }
}
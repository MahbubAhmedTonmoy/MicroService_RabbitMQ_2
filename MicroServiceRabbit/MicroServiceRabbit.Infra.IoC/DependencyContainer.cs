using MicroServiceRabbit.Domain.Core.Bus;
using MicroServiceRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroServiceRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
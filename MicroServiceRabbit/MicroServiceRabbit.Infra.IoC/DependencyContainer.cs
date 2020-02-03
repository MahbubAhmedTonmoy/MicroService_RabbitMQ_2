using MicroServiceRabbit.Banking.Application.Interfaces;
using MicroServiceRabbit.Banking.Application.Services;
using MicroServiceRabbit.Banking.Domain.Interfaces;
using MicroServiceRabbit.Domain.Core.Bus;
using MicroServiceRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using MicroServiceRabbit.Banking.Data.Repository;
using MicroServiceRabbit.Banking.Data.Context;
using MediatR;
using MicroServiceRabbit.Banking.Domain.Commands;
using MicroServiceRabbit.Banking.Domain.CommandHandlers;
using MicroServiceRabbit.Transfer.Application.Services;
using MicroServiceRabbit.Transfer.Application.Interfaces;
using MicroServiceRabbit.Transfer.Data.Repository;
using MicroServiceRabbit.Transfer.Domain.Interfaces;
using MicroServiceRabbit.Transfer.Data.Context;
using MicroServiceRabbit.Transfer.Domain.Events;
using MicroServiceRabbit.Transfer.Domain.EventHandlers;

namespace MicroServiceRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>(sp => {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //subscriptions
            services.AddTransient<TransferEventHandler>();
            //event
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler >();

            //Application
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>(); 

            //data

            services.AddTransient<IAccountRepository, AccountRepository>(); 
            services.AddTransient<ITransferRepositoy, TransferRepositoy>();
            services.AddTransient<BankingDBContext>();
            services.AddTransient<BankingDBContext_Transfer>();
        }
    }
}
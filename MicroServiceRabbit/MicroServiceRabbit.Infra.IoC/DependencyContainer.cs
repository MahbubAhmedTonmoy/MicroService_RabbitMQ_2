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

namespace MicroServiceRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler >();

            //Application
            services.AddTransient<IAccountService, AccountService>();

            //data

            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDBContext>();
        }
    }
}
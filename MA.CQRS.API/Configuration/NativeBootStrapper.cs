using MA.CQRS.CrossCutting.EventStore;
using MA.CQRS.CrossCutting.MemoryBus;
using MA.CQRS.CrossCutting.Notifier;
using MA.CQRS.Domain.Commands.Handler;
using MA.CQRS.Domain.Commands.Model;
using MA.CQRS.Domain.Events.Handler;
using MA.CQRS.Domain.Events.Model;
using MA.CQRS.Domain.Services;
using FluentValidation.Results;
using MediatR;
using NetDevPack.Mediator;

namespace MA.CQRS.API.Configuration
{
    public static class NativeBootStrapper
    {
        public static void InjectDependecies(this IServiceCollection services)
        {
            // Services Dependecies
            services.AddMediatR(typeof(Program));
            services.AddAutoMapper(typeof(Program));

            // Bus
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Command
            services.AddScoped<IRequestHandler<NewUserCommand, ValidationResult>, UserCommandHandler>();

            // Events
            services.AddScoped<INotificationHandler<NewUserEvent>, UserEventHandler>();

            // Services
            services.AddScoped<INotifierService, NotifierService>();

            // Event Store
            services.AddSingleton<IEventStore, EventStore>();
        }
    }
}

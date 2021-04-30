using Autofac;
using MassTransit;
using MassTransit.Context;
using MassTransitTest.Consumers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace MassTransitTest.Modules
{
    public class MassTransitModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.AddMassTransit(x =>
            {
                //// add a specific consumer
                //x.AddConsumer<UpdateCustomerAddressConsumer>();

                // add all consumers in the specified assembly
                x.AddConsumers(typeof(MessageConsumer).Assembly);

                //// add consumers by type
                //x.AddConsumers(typeof(ConsumerOne), typeof(ConsumerTwo));)

                x.UsingInMemory((context, cfg) =>
                {
                    cfg.ConfigureEndpoints(context);
                });
            });
        }
    }
}

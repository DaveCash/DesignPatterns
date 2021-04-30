using Autofac;
using MassTransit;
using MassTransitTest.Contracts;
using MassTransitTest.Modules;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Threading.Tasks;

namespace MassTransitTest.Commands
{
    public class MassTransitTestCommand
    {
        public static async Task RunAsync()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new LoggingModule());
            builder.RegisterModule(new MassTransitModule());

            var container = builder.Build();

            var busControl = container.Resolve<IBusControl>();

            busControl.Start();
            Console.WriteLine("Running...");

            await TestAsync(container);

            Console.WriteLine("Press any key to stop");
            Console.ReadLine();
            busControl.Stop();
            Console.WriteLine("Stopped");
        }

        public static async Task TestAsync(IContainer container)
        {
            var bus = container.Resolve<IBus>();

            var i = 1;

            while (true)
            {
                await bus.Publish<IMessage>(new
                {
                    Text = $"Publishing message number {i++}"
                });

                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}

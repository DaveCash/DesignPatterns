using Autofac;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace MassTransitTest.Modules
{
    public class LoggingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register((ctx) =>
                {
                    var factory = LoggerFactory.Create(cfg =>
                    {
                        cfg.AddConsole();
                    });

                    return factory;
                })
                .As<ILoggerFactory>()
                .SingleInstance();

            builder.RegisterGeneric(typeof(Logger<>))
                .As(typeof(ILogger<>))
                .SingleInstance();
        }
    }
}

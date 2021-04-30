using MassTransit;
using MassTransitTest.Contracts;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MassTransitTest.Consumers
{
    public class MessageConsumer : IConsumer<IMessage>
    {
        ILogger<MessageConsumer> _logger;

        public MessageConsumer(ILogger<MessageConsumer> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Consume(ConsumeContext<IMessage> context)
        {
            _logger.LogInformation($"Consumed message with text {context.Message.Text}");

            return Task.CompletedTask;
        }
    }
}
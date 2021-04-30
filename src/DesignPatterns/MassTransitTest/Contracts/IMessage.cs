using System;
using System.Collections.Generic;
using System.Text;

namespace MassTransitTest.Contracts
{
    public interface IMessage
    {
        public string Text { get; set; }
    }
}

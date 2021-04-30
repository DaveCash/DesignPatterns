using DesignPatterns.Decorator.Commands;
using MassTransitTest.Commands;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await MassTransitTestCommand.RunAsync();
        }
    }
}

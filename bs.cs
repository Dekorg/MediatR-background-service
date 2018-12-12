using System;
using Microsoft.Extensions.Hosting;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace tst
{
    public class bs : BackgroundService
    {
        private readonly IMediator mediator;
        public bs(IMediator mediator)
        {

            this.mediator = mediator;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {

                System.Threading.Thread.Sleep(10);
                Console.WriteLine("Hi");
            }
        }
    }
}

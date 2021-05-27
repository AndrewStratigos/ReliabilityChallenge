using MediatR;
using ReliabilityChallenge.Models;
using System.Threading;

namespace ReliabilityChallenge.Services
{
    public class MockRequestService
    {
        private IMediator mediator;

        public MockRequestService(IMediator mediator)
        {
            this.mediator = mediator;
            GenerateRequests();
        }

        private async void GenerateRequests() {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                await mediator.Send(new Request() { Id = i });
            }
        }
    }
}

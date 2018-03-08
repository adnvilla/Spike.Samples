using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Spike.Quote.Api.Features.Values
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Command(int id)
            {
                Id = id;
            }

            public int Id { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command>
        {
            public async Task Handle(Command message, CancellationToken cancellationToken)
            {
                //TODO Add async delete
            }
        }
    }
}
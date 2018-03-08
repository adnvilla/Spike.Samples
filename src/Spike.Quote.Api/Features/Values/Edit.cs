using MediatR;
using Spike.Quote.Api.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Spike.Quote.Api.Features.Values
{
    public class Edit
    {
        public class Command : IRequest<ValueEnvelope>
        {
            public Command(int id)
            {
                Id = id;
            }

            public int Id { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, ValueEnvelope>
        {
            public async Task<ValueEnvelope> Handle(Command message, CancellationToken cancellationToken)
            {
                //TODO Add async update
                return new ValueEnvelope(new Value
                {
                    Id = 1,
                    Name = "Value1"
                });
            }
        }
    }
}
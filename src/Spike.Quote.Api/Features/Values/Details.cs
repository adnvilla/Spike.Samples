using MediatR;
using Spike.Quote.Api.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Spike.Quote.Api.Features.Values
{
    public class Details
    {
        public class Query : IRequest<ValueEnvelope>
        {
            public Query(int id)
            {
                Id = id;
            }

            public int Id { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, ValueEnvelope>
        {
            public async Task<ValueEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {
                //TODO Add async get
                return new ValueEnvelope(new Value
                {
                    Id = 1,
                    Name = "Value1"
                });
            }
        }
    }
}
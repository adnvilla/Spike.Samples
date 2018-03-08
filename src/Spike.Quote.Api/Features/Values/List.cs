using MediatR;
using Spike.Quote.Api.Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Spike.Quote.Api.Features.Values
{
    public class List
    {
        public class Query : IRequest<ValuesEnvelope>
        {
            // TODO Add filters properties
        }

        public class QueryHandler : IRequestHandler<Query, ValuesEnvelope>
        {
            public async Task<ValuesEnvelope> Handle(Query message, CancellationToken cancellationToken)
            {
                // TODO Add async get
                return new ValuesEnvelope
                {
                    Values = new List<Value>
                    {
                        new Value
                        {
                            Id = 1,
                            Name = "Value1"
                        },
                        new Value
                        {
                            Id = 2,
                            Name = "Value2"
                        }
                    }
                };
            }
        }
    }
}
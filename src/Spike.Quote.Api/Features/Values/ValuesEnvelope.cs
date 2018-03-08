using Spike.Quote.Api.Domain;
using System.Collections.Generic;

namespace Spike.Quote.Api.Features.Values
{
    public class ValuesEnvelope
    {
        public List<Value> Values { get; set; }

        public int ValuesCount => Values?.Count ?? 0;
    }
}
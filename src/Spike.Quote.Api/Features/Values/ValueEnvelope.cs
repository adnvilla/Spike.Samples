using Spike.Quote.Api.Domain;

namespace Spike.Quote.Api.Features.Values
{
    public class ValueEnvelope
    {
        public ValueEnvelope(Value value)
        {
            Value = value;
        }

        public Value Value { get; }
    }
}
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Spike.Quote.Api.Features.Values
{
    [Route("values")]
    public class ValuesController : Controller
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET values
        [HttpGet]
        public async Task<ValuesEnvelope> Get()
        {
            return await _mediator.Send(new List.Query());
        }

        // GET values/5
        [HttpGet("{id}")]
        public async Task<ValueEnvelope> Get(int id)
        {
            return await _mediator.Send(new Details.Query(id));
        }

        // POST values
        [HttpPost]
        public async Task<ValueEnvelope> Post([FromBody]Create.Command command)
        {
            return await _mediator.Send(command);
        }

        // PUT values/5
        [HttpPut("{id}")]
        public async Task<ValueEnvelope> Edit(int id, [FromBody]Edit.Command command)
        {
            return await _mediator.Send(command);
        }

        // DELETE values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _mediator.Send(new Delete.Command(id));
        }
    }
}
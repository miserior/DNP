using CleanArchitecture.Application.Features.Temas.Commands.CreateStreamer;
using CleanArchitecture.Application.Features.Temas.Commands.DeleteTemas;
using CleanArchitecture.Application.Features.Temas.Commands.UpdateTemas;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TemasController : ControllerBase
    {
        private IMediator _mediator;

        public TemasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CrearTemas")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CrearTemas([FromBody] CreateTemasCommand command)
        {
            await _mediator.Send(command);
        }


        [HttpPut(Name = "UpdateTemas")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]

        public async Task<ActionResult> UpdateTema([FromBody] UpdateTemasCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteTemas")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]

        public async Task<ActionResult> DeleteStreamer(int id)
        {
            var command = new DeleteTemasCommand
            {
                Id = id
            };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}

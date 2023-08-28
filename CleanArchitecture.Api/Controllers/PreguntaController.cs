using CleanArchitecture.Application.Features.Preguntas.Queries.GetPreguntasList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.Intrinsics;

namespace CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("Api / Vector128 / [controller]")]
    public class PreguntaController: ControllerBase
    {
        private readonly IMediator _mediator;

        public PreguntaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{tema}", Name = "GetTema" )]
        [ProducesResponseType(typeof(IEnumerable<PreguntasVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<PreguntasVm>>> GetQuestionBySubject(string DescripcionTema)
        {
            var query = new GetPreguntasListQuery(DescripcionTema);
            var preguntas= await _mediator.Send(query);
            return Ok(preguntas);
        }
    }
}

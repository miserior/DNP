using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Preguntas.Queries.GetPreguntasList
{
    public class GetPreguntasListQueryHandler : IRequestHandler<GetPreguntasListQuery, List<PreguntasVm>>
    { // interface de comunicacion
        private readonly IPreguntaRepository _preguntaRepository;
        private readonly IMapper _mapper;

        public GetPreguntasListQueryHandler(IPreguntaRepository preguntaRepository, IMapper mapper) // mapeo
        {
            _preguntaRepository = preguntaRepository;
            _mapper = mapper;
        }

        public Task<List<PreguntasVm>> Handle(GetPreguntasListQuery request, CancellationToken cancellationToken)
        {
            var preguntaList = _preguntaRepository.GetQuestionBySubject(request._DescripcionTema);
            return _mapper.Map<List<PreguntasVm>>(preguntaList);
        }
    }
}

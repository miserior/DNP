using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Temas.Commands.CreateStreamer
{
    public class CreateTemasCommandHandler : IRequestHandler<CreateTemasCommand, int>
    {
        private readonly ITemasRepository _temasRepository;
        private IMapper _mapper;
        private readonly ILogger<CreateTemasCommandHandler> _logger;

        public CreateTemasCommandHandler(ITemasRepository temasRepository, IMapper mapper, ILogger<CreateTemasCommandHandler> logger)
        {
            _temasRepository = temasRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(CreateTemasCommand request, CancellationToken cancellationToken)
        {
            var temasEntity = _mapper.Map<TemaPregunta>(request);
            var newTema = await _temasRepository.AddAsync(temasEntity);

            _logger.LogInformation($"Tema {newTema.Id} creado exitosamente");

            return newTema.Id;
        }
    }
}

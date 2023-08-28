using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;


namespace CleanArchitecture.Application.Features.Temas.Commands.UpdateTemas
{
    public class UpdateTemasCommandHandler : IRequestHandler<UpdateTemasCommand>
    {
        private readonly ITemasRepository _temasRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateTemasCommandHandler> _logger;

        public UpdateTemasCommandHandler(ITemasRepository temasRepository, IMapper mapper, ILogger<UpdateTemasCommandHandler> logger)
        {
            _temasRepository = temasRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateTemasCommand request, CancellationToken cancellationToken)
        {
            var temasToUpdate = await _temasRepository.GetByIdAsync(request.Id);

            if (temasToUpdate == null)
            {
                _logger.LogError($"No se encontro el tema id {request.Id}");
                throw new NotFoundException(nameof(TemaPregunta), request.Id);
            }

            _mapper.Map(request, temasToUpdate, typeof(UpdateTemasCommand), typeof(TemaPregunta));

            await _temasRepository.UpdateAsync(temasToUpdate);

            _logger.LogInformation($"La operacion fue exitosa actualizando el streamer {request.Id}");

            return Unit.Value;
        }
    }
}

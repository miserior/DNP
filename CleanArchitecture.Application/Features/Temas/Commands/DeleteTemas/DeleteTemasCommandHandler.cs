using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;


namespace CleanArchitecture.Application.Features.Temas.Commands.DeleteTemas
{
    public class DeleteTemasCommandHandler : IRequestHandler<DeleteTemasCommand>
    {
        private readonly ITemasRepository _temasRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteTemasCommandHandler> _logger;

        public DeleteTemasCommandHandler(ITemasRepository streamerRepository, IMapper mapper, ILogger<DeleteTemasCommandHandler> logger)
        {
            _temasRepository = streamerRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<Unit> Handle(DeleteTemasCommand request, CancellationToken cancellationToken)
        {
            var streamerToDelete = await _temasRepository.GetByIdAsync(request.Id);
            if (streamerToDelete == null)
            {
                _logger.LogError($"{request.Id} no existe en el sistema");
                throw new NotFoundException(nameof(TemaPregunta), request.Id);
            }

            await _temasRepository.DeleteAsync(streamerToDelete);

            _logger.LogInformation($"El {request.Id} tema eliminado con exito");

            return Unit.Value;
        }
    }
}

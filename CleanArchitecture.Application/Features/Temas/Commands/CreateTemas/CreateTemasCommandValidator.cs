using FluentValidation;


namespace CleanArchitecture.Application.Features.Temas.Commands.CreateStreamer
{
    public class CreateTemasCommandValidator : AbstractValidator<CreateTemasCommand>
    {
        public CreateTemasCommandValidator()
        {
            RuleFor(p => p.DescripcionTema)
                .NotEmpty().WithMessage("vacio")
                .NotNull();
        }
    }
}

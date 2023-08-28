using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Temas.Commands.UpdateTemas
{
    public class UpdateTemasCommandValidator : AbstractValidator<UpdateTemasCommand>
    {
        public UpdateTemasCommandValidator()
        {
            RuleFor(p => p.DescripcionTema)
                .NotNull().WithMessage("{Nombre} no permite vaores nulos");
        }
    }
}

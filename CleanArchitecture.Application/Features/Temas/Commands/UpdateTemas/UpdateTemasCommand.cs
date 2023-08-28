using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Temas.Commands.UpdateTemas
{
    public class UpdateTemasCommand : IRequest
    {
        public int Id { get; set; }
        public string? DescripcionTema { get; set; } = string.Empty;
    }
}

using CleanArchitecture.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Temas.Commands.CreateStreamer
{
    public class CreateTemasCommand : IRequest<int>
    {
        public string DescripcionTema { get; set; } = string.Empty;
    }
}

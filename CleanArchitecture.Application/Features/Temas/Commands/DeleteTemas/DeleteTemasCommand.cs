using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Temas.Commands.DeleteTemas
{
    public class DeleteTemasCommand : IRequest
    {
        public int Id { get; set; }
    }
}

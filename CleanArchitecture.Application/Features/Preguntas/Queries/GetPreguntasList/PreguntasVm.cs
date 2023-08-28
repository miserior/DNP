using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Preguntas.Queries.GetPreguntasList
{
    public class PreguntasVm
    {

        public int TemaPreguntaId { get; set; }
        public string? DescripcionPregunta { get; set; }
    }
}

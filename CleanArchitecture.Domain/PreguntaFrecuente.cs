using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public class PreguntaFrecuente: BaseDomainModel
    {
        public int TemaPreguntaId { get; set; }
        public string? DescripcionPregunta { get; set; }
        public string? DescripcionRespuesta { get; set; }
        public virtual TemaPregunta? TemaPregunta { get; set; }

    }
}

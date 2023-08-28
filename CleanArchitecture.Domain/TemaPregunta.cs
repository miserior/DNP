using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public class TemaPregunta: BaseDomainModel
    {
        public string? DescripcionTema { get; set; }

        public ICollection<PreguntaFrecuente>? PreguntasFrecuentes { get; set;} // coleccion de video
    }
}

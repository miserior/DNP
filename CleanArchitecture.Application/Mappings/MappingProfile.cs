using AutoMapper;
using CleanArchitecture.Application.Features.Preguntas.Queries.GetPreguntasList;
using CleanArchitecture.Application.Features.Temas.Commands.CreateStreamer;
using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<PreguntaFrecuente, PreguntasVm>();
            CreateMap<CreateTemasCommand, TemaPregunta>();
        }
    }
}

using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class ModelDbContextSeed
    {
        public static async Task SeedAsync(ModelDbContext context, ILogger<ModelDbContextSeed> logger)
        {
            if (!context.TemasPreguntas.Any())
            {
                context.TemasPreguntas.AddRange(GetPreconfiguredStreamer());
                await context.SaveChangeAsync();
                logger.LogInformation("estamos insertando nuevos registros {context}", typeof(ModelDbContext).Name);
            }
        }
        private static IEnumerable<TemaPregunta> GetPreconfiguredStreamer()
        {
            return new List<TemaPregunta>() {
            new TemaPregunta {CreadoPor = "vaxidrex", DescripcionTema = "POT"},
            new TemaPregunta {CreadoPor = "vaxidrex", DescripcionTema = "POT2"}
            };
        }
    }
}

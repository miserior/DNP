using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
        {
        }

        public override Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.FechaCreacion = DateTime.Now;
                        entry.Entity.CreadoPor = "system";
                        break;

                    case EntityState.Modified:
                        entry.Entity.FechaModificacion = DateTime.Now;
                        entry.Entity.ModificadoPor = "system";
                        break;

                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=servpnd23.database.windows.net; Database=PNDDB;User ID=datatribox;Password=Colombia123$;Integrated Security= True;Trusted_Connection=False;Encrypt=True;")
        //        .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, Microsoft.Extensions.Logging.LogLevel.Information)
        //        .EnableSensitiveDataLogging();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TemaPregunta>()
                .HasMany(m => m.PreguntasFrecuentes)
                .WithOne(m => m.TemaPregunta)
                .HasForeignKey(m => m.TemaPreguntaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict); // Opcional si hay claves con otra convencion (Fluent api)
        }
        public DbSet<PreguntaFrecuente>? PreguntasFrecuentes { get; set; }
        public DbSet<TemaPregunta>? TemasPreguntas { get; set; }

    }
}

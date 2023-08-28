

namespace CleanArchitecture.Domain.Common
{
    public abstract class BaseDomainModel // solo para herencia abtsract
    {
        public int Id { get; set; }
        public DateTime? FechaCreacion { get; set; } // auditoria

        public string? CreadoPor { get; set; } // auditoria

        public DateTime? FechaModificacion { get; set; } // auditoria

        public string? ModificadoPor { get; set; } // auditoria
    }
}

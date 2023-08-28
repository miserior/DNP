using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class TemasRepository : RepositoryBase<TemaPregunta>, ITemasRepository
    {
        public TemasRepository(ModelDbContext context) : base(context)
        {
        }

        public async Task<TemaPregunta> GetSubjectByName(string nombreTema)
        {
           var tema = await _context.TemasPreguntas.Where(o => o.DescripcionTema == nombreTema).FirstOrDefaultAsync();
            return tema;
        }
    }
}

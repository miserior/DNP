using CleanArchitecture.Domain.Common;
using System.Linq.Expressions;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : BaseDomainModel
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        List<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate); // Le pasas un objeto de tipo expression y se tranforma en instruccion a sql

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, // ordenamiento
            string includeString = null,
            bool disableTracking = true); // metodo get asign para el ordenamiento de los resultados de manera asincrona 

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>> includes = null, // relacion entre entidades
            bool disableTracking = true); // paginacion

        Task<T> GetByIdAsync(int id); // hasta aqui metodos genericos para obtener data de cualquier entidad 

        Task<T> AddAsync(T entity); // metodos de aqui para abajo para manipular data

        Task<T> UpdateAsync(T entity);

        Task<T> DeleteAsync(T entity);

    }
}

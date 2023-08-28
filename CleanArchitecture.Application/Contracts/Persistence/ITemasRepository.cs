using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface ITemasRepository : IAsyncRepository<TemaPregunta>
    {
        Task<TemaPregunta> GetSubjectByName(string nombreVideo);
    }
}

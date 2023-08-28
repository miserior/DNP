using CleanArchitecture.Domain;


namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IPreguntaRepository: IAsyncRepository<PreguntaFrecuente> // metodos personalizados que se deseen 
    {
        Task<PreguntaFrecuente> GetDescriptionQuestion(string descripcionPregunta);
        Task<IEnumerable<PreguntaFrecuente>> GetQuestionBySubject(string descripcionRespuesta);
    }
}

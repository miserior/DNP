using MediatR;


namespace CleanArchitecture.Application.Features.Preguntas.Queries.GetPreguntasList
{
    public class GetPreguntasListQuery: IRequest<List<PreguntasVm>> // haces referencia y que esperas una lista 
    {
        public string _DescripcionTema { get; set; } = string.Empty;

        public GetPreguntasListQuery(string descripcionTema) 
        {
            _DescripcionTema = descripcionTema ?? throw new ArgumentNullException(nameof(descripcionTema));
        }
    }
}

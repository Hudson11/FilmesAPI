namespace FilmesApi.DTO;

public class PaginationDTO<IEnumerable>
{
    public PaginationDTO (IEnumerable body, int skip, int take)
    {
        Body = body;
        TotalVisualizados = take;
        QuantidadeItensPulados = skip;
    }   
    
    public IEnumerable Body { get; set; }

    public int TotalElementos { get; set; }
    public int TotalVisualizados { get; set; }
    public int QuantidadeItensPulados { get; set; }
}

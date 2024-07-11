using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{

    public Filme()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; }

    public string? Titulo { get; set; }

    public string? Genero { get; set; }

    public int Duracao { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace FilmesApi.DTO;

public class FilmeCadastroDTO
{
    [Required]
    [MaxLength(50)]
    public string Titulo { get; set; }

    [Required]
    [MaxLength(50)]
    public string Genero { get; set; }

    [Required]
    [Range(50, 300)]
    public int Duracao { get; set; }
}

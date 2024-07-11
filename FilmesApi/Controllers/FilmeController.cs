using FilmesApi.DTO;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new();

    [HttpPost]
    public IActionResult CadastrarNovoFilme([FromBody] FilmeCadastroDTO filme)
    {
        var novoFilme = new Filme
        {
            Genero = filme.Genero,
            Titulo = filme.Titulo,
            Duracao = filme.Duracao
        };

        return CreatedAtAction(nameof(RetonarFilmePorId), new { id = novoFilme.Id }, novoFilme);
    }

    [HttpGet]
    public PaginationDTO<IEnumerable<Filme>> RetornarTodosOsFilmes ([FromQuery] int take = 5, [FromQuery] int skip = 0)
    {
        var resultado = filmes.Skip(skip).Take(take);

        PaginationDTO<IEnumerable<Filme>> paginationDTO = new(resultado, skip, take);

        return paginationDTO;
    }

    [HttpGet("{id}")]
    public IActionResult RetonarFilmePorId (string id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id.Equals(id));

        if (filme == null) return NotFound();

        return Ok(filme);
    }
}

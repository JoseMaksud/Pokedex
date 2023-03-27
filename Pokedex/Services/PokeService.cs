using System.Text.Json;
using Pokedex.Models;

namespace Pokedex.Services;

public class PokeService : IPokeService
{
    private readonly IHttpContextAcessor _session;
    private readonly string pokemonFile = @"Data\pokemons.json";
    private readonly string tiposFile = @"Data\tipos.json";

    public PokeService(IHttpContextAccessor session)
    {
        _session = session;
        PopularSessao();
    }

    public List<Pokemon> GetPokemons()
    {
        PopularSessao();
        var pokemons = JsonSerializer.Deserialize<List<Pokemon>>
            (_session.HttpContext.Session.getString("Pokemons"));
        return pokemons;
    }

    public List<Tipo> GetTipos()
    {
        PopularSessao();
        var pokemons = JsonSerializer.Deserialize<List<Tipo>>
            (_session.HttpContext.Session.getString("Tipos"));
        return tipos;
    }

    
}
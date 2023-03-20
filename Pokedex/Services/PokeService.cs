using System.Text.Json;
using Pokedex.Models;

namespace Pokedex.Services;

public class PokeService : IPokeService
{
    private readonly IHttpContextAcessor _session;
}
using PokeDexBackend.Models;

namespace PokeDexBackend.Services;

public interface IPokeApi
{
    public Task<List<Pokemon>> GetPokemonList();
}
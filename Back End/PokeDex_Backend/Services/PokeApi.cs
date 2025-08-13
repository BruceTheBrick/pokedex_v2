using PokeDexBackend.Core;
using PokeDexBackend.Models;

namespace PokeDexBackend.Services;

public class PokeApi : BaseApi, IPokeApi
{
    public PokeApi() 
        : base(Endpoints.BaseUrl)
    {
    }

    public async Task<List<Pokemon>> GetPokemonList()
    {
        var response = await GetAsync<List<Pokemon>>(Endpoints.Pokemon);
        if (response is null)
        {
            return new List<Pokemon>();
        }

        return response;
    }
}
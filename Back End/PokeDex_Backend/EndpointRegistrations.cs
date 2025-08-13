using PokeDexBackend.Services;

namespace PokeDex_Backend;

public static class EndpointRegistrations
{
    public static WebApplication AddEndpoints(this WebApplication app)
    {
        app.MapGet("/pokemon", GetPokemon).WithName("GetPokemon");
        app.MapGet("/weatherforecast", GetWeatherForecast).WithName("GetWeatherForecast");
        return app;
    }

    private static Task GetWeatherForecast()
    {

        // var forecast = Enumerable.Range(1, 5).Select(index =>
        //         new WeatherForecast
        //         (
        //             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //             Random.Shared.Next(-20, 55),
        //             summaries[Random.Shared.Next(summaries.Length)]
        //         ))
        //     .ToArray();
        // return forecast;
        return Task.CompletedTask;
    }

    private static Task GetPokemon(HttpContext context)
    {
        return context.RequestServices.GetService<IPokeApi>().GetPokemonList();
    }
}
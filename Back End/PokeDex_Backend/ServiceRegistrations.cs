using PokeDexBackend.Services;

namespace PokeDex_Backend;

public static class ServiceRegistrations
{
    // Add services to the container.
    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddOpenApi();
        services.AddSingleton<IPokeApi, PokeApi>();
        return services;
    }
}
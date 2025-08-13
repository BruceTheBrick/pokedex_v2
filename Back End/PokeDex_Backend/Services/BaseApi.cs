using System.Text.Json;

namespace PokeDexBackend.Services;

public class BaseApi
{
    private readonly HttpClient _client = new();

    public BaseApi(string baseUrl)
    {
        _client.BaseAddress = new Uri(baseUrl);
    }

    protected async Task<T?> GetAsync<T>(string url)
    {
        var response = await _client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            return ParseResponseStream<T>(await response.Content.ReadAsStringAsync());
        }

        return default;
    }

    private T? ParseResponseStream<T>(string stream)
    {
        try
        {
            var result = JsonSerializer.Deserialize<T>(stream);
            return result;
        }
        catch (Exception)
        {
            return default;
        }
    }
}
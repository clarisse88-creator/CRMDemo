using System.Net.Http.Json;
namespace Web.Helpers;
public class ApiClient
{
    private readonly HttpClient _httpClient;
    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<IEnumerable<T>> GetAllAsync<T>(string endpoint)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<T>>(endpoint) ?? [];
    }
    // public async Task<T> GetAsync<T>(string endpoint)
    // {
    //    return await _httpClient.GetFromJsonAsync<T>(endpoint);
    // } 
}
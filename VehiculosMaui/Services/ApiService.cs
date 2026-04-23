using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

namespace VehiculosMaui.Services
{
    public class ApiService<T> : IApiService<T> where T : class
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;

        public ApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("api");
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<T>> GetAllAsync(string endpoint)
        {
            try
            {
                var response = await _httpClient.GetAsync(endpoint);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<List<T>>(_serializerOptions);
                    return result ?? new List<T>();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error GetAllAsync: {ex.Message}");
            }
            return new List<T>();
        }

        public async Task<T?> GetByIdAsync(string endpoint, int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{endpoint}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<T>(_serializerOptions);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error GetByIdAsync: {ex.Message}");
            }
            return null;
        }

        public async Task<T?> CreateAsync(string endpoint, T entity)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(endpoint, entity, _serializerOptions);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<T>(_serializerOptions);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error CreateAsync: {ex.Message}");
            }
            return null;
        }

        public async Task<bool> UpdateAsync(string endpoint, int id, T entity)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{endpoint}/{id}", entity, _serializerOptions);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error UpdateAsync: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteAsync(string endpoint, int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{endpoint}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error DeleteAsync: {ex.Message}");
                return false;
            }
        }
    }
}

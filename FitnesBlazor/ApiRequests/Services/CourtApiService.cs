using FitnesBlazor.ApiRequests.Models;
using System.Net.Http.Json;

namespace FitnesBlazor.ApiRequests.Services
{
    public class CourtApiService
    {
        private readonly HttpClient _httpClient;

        public CourtApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CourtListResponse?> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<CourtListResponse>("api/Court/GetAll");
        }
    }
}
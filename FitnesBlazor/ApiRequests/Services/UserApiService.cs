using FitnesBlazor.ApiRequests.Models;
using System.Net.Http.Json;

namespace FitnesBlazor.ApiRequests.Services
{
    public class UserApiService
    {
        private readonly HttpClient _httpClient;

        public UserApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AuthResponse?> Login(LoginRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/User/Login", request);

            return await response.Content.ReadFromJsonAsync<AuthResponse>();
        }

        public async Task<AuthResponse?> Register(RegisterRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/User/Register", request);

            return await response.Content.ReadFromJsonAsync<AuthResponse>();
        }
    }
}
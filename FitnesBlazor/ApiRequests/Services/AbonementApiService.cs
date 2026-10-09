using FitnesBlazor.ApiRequests.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace FitnesBlazor.ApiRequests.Services
{
    public class AbonementApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthStateService _authStateService;

        public AbonementApiService(HttpClient httpClient, AuthStateService authStateService)
        {
            _httpClient = httpClient;
            _authStateService = authStateService;
        }

        private async Task SetAuth()
        {
            var token = await _authStateService.GetToken();
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<AbonementListResponse?> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<AbonementListResponse>("api/Abonement/GetAll");
        }

        public async Task<BaseResponse?> Buy(BuyAbonementRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/UserAbonement/Buy", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<UserAbonementListResponse?> GetMyAbonements(int idUser)
        {
            await SetAuth();
            return await _httpClient.GetFromJsonAsync<UserAbonementListResponse>($"api/UserAbonement/GetByUser/{idUser}");
        }
    }
}
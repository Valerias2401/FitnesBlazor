using FitnesBlazor.ApiRequests.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace FitnesBlazor.ApiRequests.Services
{
    public class InventoryApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthStateService _authStateService;

        public InventoryApiService(HttpClient httpClient, AuthStateService authStateService)
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

        public async Task<InventoryListResponse?> GetAll()
        {
            await SetAuth();
            return await _httpClient.GetFromJsonAsync<InventoryListResponse>("api/Inventory/GetAll");
        }

        public async Task<BaseResponse?> Create(CreateInventoryRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Inventory/Create", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> UpdateStatus(UpdateInventoryStatusRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Inventory/UpdateStatus", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> Delete(int idInventory)
        {
            await SetAuth();
            var response = await _httpClient.DeleteAsync($"api/Inventory/Delete/{idInventory}");
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }
    }
}
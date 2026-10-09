using FitnesBlazor.ApiRequests.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace FitnesBlazor.ApiRequests.Services
{
    public class AnalyticsApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthStateService _authStateService;

        public AnalyticsApiService(HttpClient httpClient, AuthStateService authStateService)
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

        public async Task<AnalyticsDashboardResponse?> GetDashboard()
        {
            await SetAuth();
            var response = await _httpClient.GetFromJsonAsync<AnalyticsDashboardResponse>("api/Analytics/Dashboard");
            if (response != null) FillOldFields(response);
            return response;
        }

        public async Task<AnalyticsDashboardResponse?> GetGeneralStatistics()
        {
            return await GetDashboard();
        }

        public async Task<AnalyticsDashboardResponse?> GetRevenue()
        {
            return await GetDashboard();
        }

        private void FillOldFields(AnalyticsDashboardResponse response)
        {
            response.statistics = new GeneralStatisticsModel
            {
                usersCount = response.data.usersCount,
                bookingsCount = response.data.totalBookings,
                activeBookings = response.data.activeBookings,
                sectionsCount = response.data.sectionsCount,
                eventsCount = response.data.eventsCount,
                inventoryCount = response.data.inventoryCount
            };
            response.revenue = response.data.totalRevenue;
        }
    }
}
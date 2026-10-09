using FitnesBlazor.ApiRequests.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace FitnesBlazor.ApiRequests.Services
{
    public class BookingApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthStateService _authStateService;

        public BookingApiService(HttpClient httpClient, AuthStateService authStateService)
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

        public async Task<BookingListResponse?> GetAll()
        {
            await SetAuth();
            return await _httpClient.GetFromJsonAsync<BookingListResponse>("api/Booking/GetAll");
        }

        public async Task<BookingListResponse?> GetByUser(int idUser)
        {
            await SetAuth();
            return await _httpClient.GetFromJsonAsync<BookingListResponse>($"api/Booking/GetByUser/{idUser}");
        }

        public async Task<BaseResponse?> Create(CreateBookingRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Booking/Create", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> Cancel(int idBooking)
        {
            await SetAuth();
            var response = await _httpClient.PostAsync($"api/Booking/Cancel/{idBooking}", null);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }
    }
}
using FitnesBlazor.ApiRequests.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace FitnesBlazor.ApiRequests.Services
{
    public class EventApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthStateService _authStateService;

        public EventApiService(HttpClient httpClient, AuthStateService authStateService)
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

        public async Task<EventListResponse?> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<EventListResponse>("api/Event/GetAll");
        }

        public async Task<BaseResponse?> Create(CreateEventRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Event/Create", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> UpdateOrganization(UpdateEventOrganizationRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Event/UpdateOrganization", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> AddParticipant(EventParticipantRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Event/AddParticipant", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> DeleteParticipant(int idParticipant)
        {
            await SetAuth();
            var response = await _httpClient.DeleteAsync($"api/Event/DeleteParticipant/{idParticipant}");
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<EventParticipantListResponse?> GetParticipants(int idEvent)
        {
            await SetAuth();
            return await _httpClient.GetFromJsonAsync<EventParticipantListResponse>($"api/Event/GetParticipants/{idEvent}");
        }

        public async Task<BaseResponse?> CreateGame(CreateEventGameRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Event/CreateGame", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<EventGameListResponse?> GetGames(int idEvent)
        {
            return await _httpClient.GetFromJsonAsync<EventGameListResponse>($"api/Event/GetGames/{idEvent}");
        }

        public async Task<BaseResponse?> UpdateGameResult(UpdateEventGameResultRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Event/UpdateGameResult", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> DeleteGame(int idGame)
        {
            await SetAuth();
            var response = await _httpClient.DeleteAsync($"api/Event/DeleteGame/{idGame}");
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> AddResult(CreateEventResultRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Event/AddResult", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }
    }
}
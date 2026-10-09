using FitnesBlazor.ApiRequests.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace FitnesBlazor.ApiRequests.Services
{
    public class SectionApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthStateService _authStateService;

        public SectionApiService(HttpClient httpClient, AuthStateService authStateService)
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

        public async Task<SectionListResponse?> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<SectionListResponse>("api/Section/GetAll");
        }

        public async Task<BaseResponse?> Create(CreateSectionRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Section/Create", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<BaseResponse?> Enroll(EnrollSectionRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Section/Enroll", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<SectionEnrollmentListResponse?> GetEnrollments(int idSection)
        {
            await SetAuth();
            return await _httpClient.GetFromJsonAsync<SectionEnrollmentListResponse>($"api/Section/GetEnrollments/{idSection}");
        }

        public async Task<BaseResponse?> MarkAttendance(MarkAttendanceRequest request)
        {
            await SetAuth();
            var response = await _httpClient.PostAsJsonAsync("api/Section/MarkAttendance", request);
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }

        public async Task<SectionAttendanceListResponse?> GetAttendance(int idSection)
        {
            await SetAuth();
            return await _httpClient.GetFromJsonAsync<SectionAttendanceListResponse>($"api/Section/GetAttendance/{idSection}");
        }

        public async Task<BaseResponse?> DeleteEnrollment(int idEnrollment)
        {
            await SetAuth();
            var response = await _httpClient.DeleteAsync($"api/Section/DeleteEnrollment/{idEnrollment}");
            return await response.Content.ReadFromJsonAsync<BaseResponse>();
        }
    }
}
using FitnesBlazor.ApiRequests.Models;
using Microsoft.JSInterop;
using System.Text.Json;

namespace FitnesBlazor.ApiRequests.Services
{
    public class AuthStateService
    {
        private readonly IJSRuntime _jsRuntime;

        public AuthStateService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task SaveAuthData(AuthResponse response)
        {
            if (response.user == null)
                return;

            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "token", response.token);

            string userJson = JsonSerializer.Serialize(response.user);

            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "user", userJson);
        }

        public async Task<UserModel?> GetCurrentUser()
        {
            string? userJson = await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", "user");

            if (string.IsNullOrEmpty(userJson))
                return null;

            return JsonSerializer.Deserialize<UserModel>(userJson);
        }

        public async Task<string?> GetToken()
        {
            return await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", "token");
        }

        public async Task<bool> IsAuthorized()
        {
            UserModel? user = await GetCurrentUser();

            return user != null;
        }

        public async Task Logout()
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "token");
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "user");
        }
    }
}
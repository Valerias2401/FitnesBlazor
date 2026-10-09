namespace FitnesBlazor.ApiRequests.Models
{
    public class AuthResponse
    {
        public bool status { get; set; }

        public string message { get; set; } = string.Empty;

        public string token { get; set; } = string.Empty;

        public UserModel? user { get; set; }
    }
}
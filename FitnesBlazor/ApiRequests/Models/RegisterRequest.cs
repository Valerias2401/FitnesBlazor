namespace FitnesBlazor.ApiRequests.Models
{
    public class RegisterRequest
    {
        public string full_name { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public string phone { get; set; } = string.Empty;

        public DateTime birth_date { get; set; }
    }
}
namespace FitnesBlazor.ApiRequests.Models
{
    public class UserModel
    {
        public int id_user { get; set; }

        public string full_name { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public decimal balance { get; set; }

        public int id_role { get; set; }
    }
}
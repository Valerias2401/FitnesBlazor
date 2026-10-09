namespace FitnesBlazor.ApiRequests.Models
{
    public class UserAbonementModel
    {
        public int id_user_abonement { get; set; }
        public int id_abonement { get; set; }
        public string name { get; set; } = string.Empty;
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public bool is_active { get; set; }
    }
}
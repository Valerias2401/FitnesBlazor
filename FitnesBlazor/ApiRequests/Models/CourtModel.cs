namespace FitnesBlazor.ApiRequests.Models
{
    public class CourtModel
    {
        public int id_court { get; set; }

        public string name { get; set; } = string.Empty;

        public string? sport_type { get; set; }

        public decimal price_per_hour { get; set; }
    }
}
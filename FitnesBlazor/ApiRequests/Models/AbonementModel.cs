namespace FitnesBlazor.ApiRequests.Models
{
    public class AbonementModel
    {
        public int id_abonement { get; set; }

        public string name_abonement { get; set; } = string.Empty;

        public decimal price { get; set; }

        public int duration_days { get; set; }

        public string? description { get; set; }
    }
}
namespace FitnesBlazor.ApiRequests.Models
{
    public class SportEventModel
    {
        public int id_event { get; set; }

        public string name { get; set; } = string.Empty;

        public string? description { get; set; }

        public DateTime event_date { get; set; }

        public int id_court { get; set; }

        public string court_name { get; set; } = string.Empty;

        public int max_participants { get; set; }

        public int participants_count { get; set; }

        public string bracket_info { get; set; } = string.Empty;

        public string game_schedule { get; set; } = string.Empty;

        public string photo_gallery { get; set; } = string.Empty;

        public string status { get; set; } = string.Empty;
    }
}
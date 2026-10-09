namespace FitnesBlazor.ApiRequests.Models
{
    public class SectionModel
    {
        public int id_section { get; set; }

        public string name { get; set; } = string.Empty;

        public int? trainer_id { get; set; }

        public string trainer_name { get; set; } = string.Empty;

        public int? max_participants { get; set; }

        public DateTime schedule_time { get; set; }

        public int participants_count { get; set; }
    }
}
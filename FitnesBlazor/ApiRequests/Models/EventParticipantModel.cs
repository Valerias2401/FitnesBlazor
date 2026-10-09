namespace FitnesBlazor.ApiRequests.Models
{
    public class EventParticipantModel
    {
        public int id_participant { get; set; }

        public int id_event { get; set; }

        public int id_user { get; set; }

        public string user_name { get; set; } = string.Empty;

        public string user_email { get; set; } = string.Empty;

        public string user_phone { get; set; } = string.Empty;
    }
}
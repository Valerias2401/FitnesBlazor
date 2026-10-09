namespace FitnesBlazor.ApiRequests.Models
{
    public class EventParticipantListResponse
    {
        public bool status { get; set; }

        public List<EventParticipantModel> data { get; set; } = new();
    }
}
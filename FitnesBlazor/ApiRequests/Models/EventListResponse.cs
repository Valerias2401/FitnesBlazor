namespace FitnesBlazor.ApiRequests.Models
{
    public class EventListResponse
    {
        public bool status { get; set; }

        public List<SportEventModel> data { get; set; } = new();
    }
}
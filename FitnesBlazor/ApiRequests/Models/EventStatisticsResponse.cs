namespace FitnesBlazor.ApiRequests.Models
{
    public class EventStatisticsResponse
    {
        public bool status { get; set; }

        public EventStatisticsModel? statistics { get; set; }
    }
}
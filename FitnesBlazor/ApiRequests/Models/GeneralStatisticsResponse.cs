namespace FitnesBlazor.ApiRequests.Models
{
    public class GeneralStatisticsResponse
    {
        public bool status { get; set; }

        public GeneralStatisticsModel? statistics { get; set; }
    }
}
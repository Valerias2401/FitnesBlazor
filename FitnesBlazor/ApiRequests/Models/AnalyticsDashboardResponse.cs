namespace FitnesBlazor.ApiRequests.Models
{
    public class AnalyticsDashboardResponse
    {
        public bool status { get; set; }

        public AnalyticsDashboardModel data { get; set; } = new();

        public GeneralStatisticsModel statistics { get; set; } = new();

        public decimal revenue { get; set; }
    }
}
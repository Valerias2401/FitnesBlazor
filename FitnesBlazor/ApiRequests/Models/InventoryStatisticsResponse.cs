namespace FitnesBlazor.ApiRequests.Models
{
    public class InventoryStatisticsResponse
    {
        public bool status { get; set; }

        public InventoryStatisticsModel? statistics { get; set; }
    }
}
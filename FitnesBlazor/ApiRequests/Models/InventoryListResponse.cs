namespace FitnesBlazor.ApiRequests.Models
{
    public class InventoryListResponse
    {
        public bool status { get; set; }

        public List<InventoryModel> data { get; set; } = new();
    }
}
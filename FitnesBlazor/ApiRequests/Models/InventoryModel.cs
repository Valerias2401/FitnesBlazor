namespace FitnesBlazor.ApiRequests.Models
{
    public class InventoryModel
    {
        public int id_inventory { get; set; }

        public string name { get; set; } = string.Empty;

        public string category { get; set; } = string.Empty;

        public int quantity { get; set; }

        public string status { get; set; } = string.Empty;

        public bool need_repair { get; set; }

        public bool purchase_required { get; set; }

        public string? comment { get; set; }
    }
}
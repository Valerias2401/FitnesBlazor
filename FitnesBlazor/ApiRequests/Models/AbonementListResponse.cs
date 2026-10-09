namespace FitnesBlazor.ApiRequests.Models
{
    public class AbonementListResponse
    {
        public bool status { get; set; }

        public List<AbonementModel> data { get; set; } = new();
    }
}
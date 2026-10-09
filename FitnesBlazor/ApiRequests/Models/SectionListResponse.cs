namespace FitnesBlazor.ApiRequests.Models
{
    public class SectionListResponse
    {
        public bool status { get; set; }

        public List<SectionModel> data { get; set; } = new();
    }
}
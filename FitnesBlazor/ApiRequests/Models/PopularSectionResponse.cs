namespace FitnesBlazor.ApiRequests.Models
{
    public class PopularSectionResponse
    {
        public bool status { get; set; }

        public List<PopularSectionModel> data { get; set; } = new();
    }
}
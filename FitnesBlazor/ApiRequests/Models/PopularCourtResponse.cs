namespace FitnesBlazor.ApiRequests.Models
{
    public class PopularCourtResponse
    {
        public bool status { get; set; }

        public List<PopularCourtModel> data { get; set; } = new();
    }
}
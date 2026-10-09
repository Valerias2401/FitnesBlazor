namespace FitnesBlazor.ApiRequests.Models
{
    public class CourtListResponse
    {
        public bool status { get; set; }

        public List<CourtModel> data { get; set; } = new();
    }
}
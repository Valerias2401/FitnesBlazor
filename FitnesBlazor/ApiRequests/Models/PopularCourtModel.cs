namespace FitnesBlazor.ApiRequests.Models
{
    public class PopularCourtModel
    {
        public string court_name { get; set; } = string.Empty;

        public int bookings_count { get; set; }
    }
}
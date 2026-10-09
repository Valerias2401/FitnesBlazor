namespace FitnesBlazor.ApiRequests.Models
{
    public class BookingListResponse
    {
        public bool status { get; set; }

        public List<BookingModel> data { get; set; } = new();
    }
}
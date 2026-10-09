namespace FitnesBlazor.ApiRequests.Models
{
    public class CreateBookingRequest
    {
        public int id_user { get; set; }

        public int id_court { get; set; }

        public DateTime booking_date { get; set; } = DateTime.Today;

        public TimeOnly? start_time { get; set; }
            = new TimeOnly(10, 0);

        public TimeOnly? end_time { get; set; }
            = new TimeOnly(11, 0);
    }
}
namespace FitnesBlazor.ApiRequests.Models
{
    public class BookingModel
    {
        public int id_booking { get; set; }

        public int id_user { get; set; }

        public string user_name { get; set; } = string.Empty;

        public int id_court { get; set; }

        public string court_name { get; set; } = string.Empty;

        public string sport_type { get; set; } = string.Empty;

        public DateTime booking_date { get; set; }

        public TimeSpan start_time { get; set; }

        public TimeSpan end_time { get; set; }

        public decimal payment_amount { get; set; }

        public string qr_code { get; set; } = string.Empty;

        public string status { get; set; } = string.Empty;
    }
}
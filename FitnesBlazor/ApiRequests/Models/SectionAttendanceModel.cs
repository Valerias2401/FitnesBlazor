namespace FitnesBlazor.ApiRequests.Models
{
    public class SectionAttendanceModel
    {
        public int id_attendance { get; set; }

        public int id_enrollment { get; set; }

        public string user_name { get; set; } = string.Empty;

        public string section_name { get; set; } = string.Empty;

        public DateTime attendance_date { get; set; }

        public bool is_present { get; set; }

        public string? comment { get; set; }
    }
}
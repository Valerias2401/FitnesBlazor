namespace FitnesBlazor.ApiRequests.Models
{
    public class SectionAttendanceListResponse
    {
        public bool status { get; set; }

        public List<SectionAttendanceModel> data { get; set; } = new();
    }
}
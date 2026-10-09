namespace FitnesBlazor.ApiRequests.Models
{
    public class SectionEnrollmentListResponse
    {
        public bool status { get; set; }

        public List<SectionEnrollmentModel> data { get; set; } = new();
    }
}
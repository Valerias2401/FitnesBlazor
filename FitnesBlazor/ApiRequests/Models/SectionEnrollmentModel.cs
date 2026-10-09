namespace FitnesBlazor.ApiRequests.Models
{
    public class SectionEnrollmentModel
    {
        public int id_enrollment { get; set; }

        public int id_user { get; set; }

        public string user_name { get; set; } = string.Empty;

        public int id_section { get; set; }

        public string section_name { get; set; } = string.Empty;
    }
}
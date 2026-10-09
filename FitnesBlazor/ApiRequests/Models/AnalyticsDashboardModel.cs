namespace FitnesBlazor.ApiRequests.Models
{
    public class AnalyticsDashboardModel
    {
        public int usersCount { get; set; }

        public int totalBookings { get; set; }

        public int bookingsCount { get; set; }

        public int activeBookings { get; set; }

        public int cancelledBookings { get; set; }

        public decimal totalRevenue { get; set; }

        public int courtsCount { get; set; }

        public int sectionsCount { get; set; }

        public int sectionEnrollmentsCount { get; set; }

        public int attendanceTotal { get; set; }

        public int attendancePresent { get; set; }

        public int attendanceAbsent { get; set; }

        public int eventsCount { get; set; }

        public int eventParticipantsCount { get; set; }

        public int inventoryCount { get; set; }

        public int repairCount { get; set; }

        public int purchaseRequiredCount { get; set; }

        public List<PopularCourtModel> popularCourts { get; set; } = new();

        public List<PopularSectionModel> popularSections { get; set; } = new();
    }
}
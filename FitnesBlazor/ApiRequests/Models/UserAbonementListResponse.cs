namespace FitnesBlazor.ApiRequests.Models
{
    public class UserAbonementListResponse
    {
        public bool status { get; set; }
        public List<UserAbonementModel> data { get; set; } = new();
    }
}
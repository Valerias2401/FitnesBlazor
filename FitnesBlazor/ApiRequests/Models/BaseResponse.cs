namespace FitnesBlazor.ApiRequests.Models
{
    public class BaseResponse
    {
        public bool status { get; set; }

        public string message { get; set; } = string.Empty;
    }
}
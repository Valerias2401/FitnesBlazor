using FitnesBlazor.ApiRequests.Models;

namespace FitnesBlazor.ApiRequests.Services
{
    public class AccessControlService
    {
        public bool CanOpenPage(string path, UserModel? user)
        {
            path = path.ToLower();

            if (user == null)
                return path == "/login" || path == "/register";

            if (path == "/login" || path == "/register")
                return false;

            if (path == "/" || path == "/access-denied")
                return true;

            if (user.id_role == 1)
            {
                return path == "/abonements" ||
                       path == "/courts" ||
                       path == "/bookings" ||
                       path == "/sections" ||
                       path == "/events" ||
                       path == "/inventory" ||
                       path == "/analytics";
            }

            if (user.id_role == 2)
            {
                return path == "/sections" ||
                       path == "/events";
            }

            if (user.id_role == 3)
            {
                return path == "/abonements" ||
                       path == "/courts" ||
                       path == "/bookings" ||
                       path == "/sections" ||
                       path == "/events";
            }

            if (user.id_role == 4)
            {
                return path == "/courts" ||
                       path == "/bookings" ||
                       path == "/events";
            }

            return false;
        }
    }
}
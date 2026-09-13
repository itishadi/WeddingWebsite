using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WeddingWebsite.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string GuestName { get; set; } = "";

        public string GuestMessage { get; set; } = "";

        public bool WillAttend { get; set; }

        public string EventDate { get; set; } = "";

        public string EventTime { get; set; } = "";

        public string EventLocation { get; set; } = "";

        public void OnGet()
        {
            GuestName = TempData["GuestName"]?.ToString() ?? "";

            GuestMessage = TempData["GuestMessage"]?.ToString() ?? "";

            bool.TryParse(
                TempData["WillAttend"]?.ToString(),
                out bool willAttend
            );

            WillAttend = willAttend;

            // Event information
            EventDate = "20 juni 2027";
            EventTime = "15:00";
            EventLocation = "Stockholm";
        }
    }
}
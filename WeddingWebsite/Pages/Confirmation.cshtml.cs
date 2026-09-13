using Microsoft.AspNetCore.Mvc.RazorPages;
using WeddingWebsite.Models;

namespace WeddingWebsite.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string GuestName { get; set; } = "";
        public string GuestMessage { get; set; } = "";
        public bool WillAttend { get; set; }

        public Event EventInfo { get; set; } = new();

        public void OnGet()
        {
            GuestName = TempData["GuestName"]?.ToString() ?? "";
            GuestMessage = TempData["GuestMessage"]?.ToString() ?? "";

            bool.TryParse(
                TempData["WillAttend"]?.ToString(),
                out bool willAttend);

            WillAttend = willAttend;

            EventInfo = new Event
            {
                Title = "Vårt bröllop",
                Date = "20 juni 2027",
                Time = "15:00",
                Location = "Stockholm"
            };
        }
    }
}
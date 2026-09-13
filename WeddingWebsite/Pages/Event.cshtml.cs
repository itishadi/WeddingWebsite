using Microsoft.AspNetCore.Mvc.RazorPages;
using WeddingWebsite.Models;

namespace WeddingWebsite.Pages
{
    public class EventModel : PageModel
    {
        public Event EventInfo { get; set; } = new();

        public void OnGet()
        {
            EventInfo = new Event
            {
                Title = "Emma & Lucas Wedding",
                Date = "20 September 2026",
                Time = "17:00",
                Location = "Malmö Wedding Hall"
            };
        }
    }
}
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
                Title = "Hasse & Sara Wedding",
                Date = "20 juni 2027",
                Time = "15:00",
                Location = "Stockholm Wedding Hall"
            };
        }
    }
}
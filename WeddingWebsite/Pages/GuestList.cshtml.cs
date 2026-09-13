using Microsoft.AspNetCore.Mvc.RazorPages;
using WeddingWebsite.Models;

namespace WeddingWebsite.Pages
{
    public class GuestListModel : PageModel
    {
        private readonly GuestManager guestManager;

        public GuestListModel(GuestManager guestManager)
        {
            this.guestManager = guestManager;
        }

        public List<Guest> Guests { get; set; } = new();

        public void OnGet()
        {
            Guests = guestManager.GetAll();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeddingWebsite.Models;

namespace WeddingWebsite.Pages
{
    public class RsvpModel : PageModel
    {
        private readonly GuestManager guestManager;

        public RsvpModel(GuestManager guestManager)
        {
            this.guestManager = guestManager;
        }

        [BindProperty]
        public Guest Guest { get; set; } = new();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Guest.Id = guestManager.NumOfGuests + 1;
            guestManager.Add(Guest);

            TempData["GuestName"] = Guest.Name;
            TempData["GuestEmail"] = Guest.Email;
            TempData["GuestMessage"] = Guest.Message;
            TempData["WillAttend"] = Guest.WillAttend!.Value;

            return RedirectToPage("/Confirmation");
        }
    }
}
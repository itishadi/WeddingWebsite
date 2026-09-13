//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using WeddingWebsite.Models;

//namespace WeddingWebsite.Pages
//{
//    public class RsvpModel : PageModel
//    {
//        [BindProperty]
//        public Guest Guest { get; set; } = new Guest();

//        public IActionResult OnPost()
//        {
//            // Name
//            if (string.IsNullOrWhiteSpace(Guest.Name))
//            {
//                ModelState.AddModelError(
//                    "Guest.Name",
//                    "Vänligen skriv ditt namn."
//                );
//            }

//            // Email
//            if (string.IsNullOrWhiteSpace(Guest.Email))
//            {
//                ModelState.AddModelError(
//                    "Guest.Email",
//                    "Vänligen skriv din e-postadress."
//                );
//            }

//            // Message
//            if (string.IsNullOrWhiteSpace(Guest.Message))
//            {
//                ModelState.AddModelError(
//                    "Guest.Message",
//                    "Vänligen skriv ett meddelande."
//                );
//            }

//            // Ja eller Nej
//            if (!Guest.WillAttend.HasValue)
//            {
//                ModelState.AddModelError(
//                    "Guest.WillAttend",
//                    "Vänligen välj Ja eller Nej."
//                );
//            }

//            // Om något saknas
//            if (!ModelState.IsValid)
//            {
//                return Page();
//            }

//            // Spara information
//            TempData["GuestName"] = Guest.Name;
//            TempData["GuestEmail"] = Guest.Email;
//            TempData["GuestMessage"] = Guest.Message;
//            TempData["WillAttend"] = Guest.WillAttend!.Value;

//            // Gå vidare
//            return RedirectToPage("/Confirmation");
//        }
//    }
//}
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
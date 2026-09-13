using System.ComponentModel.DataAnnotations;

namespace WeddingWebsite.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vänligen skriv ditt namn.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Vänligen skriv din e-postadress.")]
        [EmailAddress(ErrorMessage = "Vänligen ange en giltig e-postadress.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Vänligen välj Ja eller Nej.")]
        public bool? WillAttend { get; set; }

        [Required(ErrorMessage = "Vänligen skriv ett meddelande.")]
        [MaxLength(200, ErrorMessage = "Meddelandet får vara högst 200 tecken.")]
        public string Message { get; set; } = "";
    }
}
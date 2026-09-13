//using System.ComponentModel.DataAnnotations;

//namespace WeddingWebsite.Models
//{
//    public class Guest
//    {
//        public int Id { get; set; }

//        [Required]
//        public string Name { get; set; } = "";

//        [EmailAddress]
//        public string Email { get; set; } = "";

//        public bool? WillAttend { get; set; } 

//        [MaxLength(200)]
//        public string Message { get; set; } = "";
//    }
//}
using System.ComponentModel.DataAnnotations;

public class Guest
{
    [Required(ErrorMessage = "Vänligen skriv ditt namn.")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Vänligen skriv din e-postadress.")]
    [EmailAddress(ErrorMessage = "Vänligen ange en giltig e-postadress.")]
    public string Email { get; set; } = "";

    public bool? WillAttend { get; set; }

    [Required(ErrorMessage = "Vänligen skriv ett meddelande.")]
    public string Message { get; set; } = "";
}

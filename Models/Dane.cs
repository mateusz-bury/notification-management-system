using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Models
{
    public class ContactFormModel
    {
        public string Imie { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }

    [Required(ErrorMessage = "Prosze podaj Imie")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Prosze podaj Email")]
    [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Prosze podaj Temat")]
    public string Temat { get; set; }

    [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
    [MinLength(10), MaxLength(50)]
    public string Tresc { get; set; }
}
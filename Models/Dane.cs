using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Models
{
    public class Dane
    {
        public string Imie { get; set; }
        public string Email { get; set; }
        public string Temat { get; set; }
        public string Tresc { get; set; }
    }

    public class WalidacjaDanych: Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string Temat { get; set; }
        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string Tresc { get; set; }
    }
}
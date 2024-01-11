using System.ComponentModel.DataAnnotations;
using System_zarządzania_błędami.Entities;

namespace System_zarządzania_błędami.Models
{
    public class AddUserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole Imię jest wymagane.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole Nazwisko jest wymagane.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Pole Login jest wymagane.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Pole Hasło jest wymagane.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pole Email jest wymagane.")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu email.")]
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}

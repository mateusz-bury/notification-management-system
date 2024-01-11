using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole Name jest wymagane.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole LastName jest wymagane.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Pole Login jest wymagane.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Pole Password jest wymagane.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Pole Email jest wymagane.")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu email.")]
        public string Email { get; set; }

        public bool IsAdmin { get; set; }

        public ICollection<UserReports> UserReports { get; set; }
    }
}

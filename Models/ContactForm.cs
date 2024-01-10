using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Models
{
    public class ContactFormModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public string? PasswordConfirm {  get; set; }
        public string PhoneNumber { get; set; }
        public string Age { get; set;}
        public string City { get; set; }
    }
}
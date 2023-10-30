using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Models
{
    public class ContactFormModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Entities
{
    public class Users
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password{ get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<UserReports> UserReports { get; set; }
    }
}

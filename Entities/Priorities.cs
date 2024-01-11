using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Entities
{
    public class Priorities
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
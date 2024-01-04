using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System_zarządzania_błędami.Entities
{
    public class Errors
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public int PriorityId { get; set; }
        public Priorities Priorities { get; set; } // relacja jeden do wielu
    }
}

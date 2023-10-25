using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Models
{
    public class category
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDataTime { get; set; } = DateTime.Now;
    }
}

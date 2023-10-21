﻿using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Models
{
    public class category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreateDataTime { get; set; } = DateTime.Now;
    }
}
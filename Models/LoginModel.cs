﻿using System.ComponentModel.DataAnnotations;

namespace System_zarządzania_błędami.Models
{
    public class LoginModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

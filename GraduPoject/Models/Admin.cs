﻿using System.ComponentModel.DataAnnotations;

namespace GraduPoject.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
    }
}

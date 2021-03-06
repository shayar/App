using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace App.API.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required] 
        public string Username { get; set; }

        [Required] 
        public byte[] PasswordHash { get; set; }

        [Required] 
        public byte[] PasswordSalt { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
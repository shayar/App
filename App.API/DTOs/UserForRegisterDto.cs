using System.ComponentModel.DataAnnotations;

namespace App.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }    

        [Required] 
        [StringLength(24, MinimumLength = 8, ErrorMessage = "You must specify password between 8 and 24 characters")]
        public string Password { get; set; }     
    }
}
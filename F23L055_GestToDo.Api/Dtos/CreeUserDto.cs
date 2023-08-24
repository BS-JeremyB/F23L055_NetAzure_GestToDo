using System.ComponentModel.DataAnnotations;

namespace F23L055_GestToDo.Api.Dtos
{
    public class CreeUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string VerificationPassword { get; set; }
    }
}


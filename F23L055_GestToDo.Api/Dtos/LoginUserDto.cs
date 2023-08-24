using System.ComponentModel.DataAnnotations;

namespace F23L055_GestToDo.Api.Dtos
{
    public class LoginUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}


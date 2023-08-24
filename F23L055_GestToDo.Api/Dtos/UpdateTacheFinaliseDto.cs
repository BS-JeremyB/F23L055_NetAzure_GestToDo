using System.ComponentModel.DataAnnotations;

namespace F23L055_GestToDo.Api.Dtos
{
    public class UpdateTacheFinaliseDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public bool Finalise { get; set; }
    }
}

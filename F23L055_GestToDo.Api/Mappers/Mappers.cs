using F23L055_GestToDo.Api.Dtos;
using F23L055_GestToDo.Bll.Entities;

namespace F23L055_GestToDo.Api.Mappers
{
    internal static class Mappers
    {
        internal static GetUserDto ToDto(this User user)
        {
            return new GetUserDto
            {
                Id = user.Id,
                Email = user.Email,
                Role = user.Role.ToString()
            };
        }
    }
}

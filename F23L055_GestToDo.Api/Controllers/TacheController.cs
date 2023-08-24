using F23L055_GestToDo.Api.Dtos;
using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace F23L055_GestToDo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TacheController : ControllerBase
    {
        private readonly ITacheRepository _tacheRepository;

        public TacheController(ITacheRepository tacheRepository)
        {
            _tacheRepository = tacheRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tacheRepository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            if (_tacheRepository.GetById(id) is not null)
            {
                return Ok(_tacheRepository.GetById(id));
            }

            return BadRequest();
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreeTacheDto dto)
        {
            Claim? userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId");

            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
            {
                if (!_tacheRepository.CreerTache(new Tache(dto.Titre, userId)))
                {
                    return BadRequest();
                }

                return NoContent();
            }

            return BadRequest();
        }

        [HttpPatch]
        public IActionResult UpdateTacheFinalise([FromBody] UpdateTacheFinaliseDto dto)
        {
            Claim? userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "UserId");

            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
            {
                if (!_tacheRepository.UpdateTacheFinalise(new Tache(dto.Id, dto.Finalise, userId)))
                {
                    return BadRequest();
                }

                return NoContent();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult DeleteTache(int id)
        {
            if (!_tacheRepository.DeleteTache(id))
            {
                return BadRequest();
            }

            return NoContent();
        }



    }
}

using F23L055_GestToDo.Api.Dtos;
using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F23L055_GestToDo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            if (!_tacheRepository.CreerTache(new Tache(dto.Titre)))
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpPatch]
        public IActionResult UpdateTacheFinalise([FromBody] UpdateTacheFinaliseDto dto)
        {
            if (!_tacheRepository.UpdateTacheFinalise(new Tache(dto.Id, dto.Finalise)))
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
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

using AfaOHS.Application.Repositories.IEntityRepositories.RepDangerLevel;
using AfaOHS.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AfaOHS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangerLevelController : ControllerBase
    {
        readonly private IDangerLevelWriteRepository _dangerLevelWriteRepository;
        readonly private IDangerLevelReadRepository _dangerLevelReadRepository;

        public DangerLevelController(IDangerLevelWriteRepository dangerLevelWriteRepository, IDangerLevelReadRepository dangerLevelReadRepository)
        {
            _dangerLevelWriteRepository = dangerLevelWriteRepository;
            _dangerLevelReadRepository = dangerLevelReadRepository;
        }

        [HttpGet("GetDangerLevels")]
        public IActionResult GetDangerLevels()
        {
            List<DangerLevel> data = _dangerLevelReadRepository.GetAll().ToList();
            if (data.Count > 0) return Ok(data);
            else return NoContent();
        }
        [HttpGet("GetDangerLevelById/{id}")]
        public async Task<IActionResult> GetDangerLevelById(int id)
        {
            DangerLevel data = await _dangerLevelReadRepository.GetByIdAsync(id);
            if (data.DangerLevelId > 0) return Ok(data);
            else return NoContent();
        }
        [HttpPost("PutDangerLevel")]
        public async Task<IActionResult> PutDangerLevel(DangerLevel dangerLevel)
        {
            bool result = await _dangerLevelWriteRepository.AddAsync(dangerLevel);
            int result2 = await _dangerLevelWriteRepository.SaveAsync();
            return result ? Ok(result2) : StatusCode(404);
        }
        [HttpPut("UpdateDangerLevel")]
        public async Task<IActionResult> UpdateDangerLevel(DangerLevel dangerLevel)
        {
            bool result = _dangerLevelWriteRepository.Update(dangerLevel);
            int id = await _dangerLevelWriteRepository.SaveAsync();
            return result ? Ok() : StatusCode(404);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using QPool.Service.Interfaces;

namespace QPool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TechnologyController : Controller
    {
        private readonly ITechnologyService _technologyService;

        public TechnologyController(ITechnologyService technologyService)
        {
            _technologyService = technologyService;
        }
        [HttpGet("technologies")]
        public async Task<IActionResult> GetTechnologies()
        {
            var technologies = await _technologyService.GetAllTechnologiesAsync();
            return Ok(technologies);
        }

        [HttpGet("technologies/{id}")]
        public async Task<IActionResult> GetTechnologyWithQuestions(int id)
        {
            var technology = await _technologyService.GetTechnologyWithQuestionsAsync(id);
            if (technology == null)
            {
                return NotFound();
            }
            return Ok(technology);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using QPool.Service.Interfaces;
using QPool.Service.Services;
using QPool.Shared.DTO;

namespace QPool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadQuestions([FromBody] List<QuestionDto> questions)
        {
            if (questions == null || !questions.Any())
            {
                return BadRequest("Invalid data.");
            }

            foreach (var question in questions)
            {
                await _questionService.AddQuestionAsync(question);
            }

            return Ok("Questions uploaded successfully.");
        }
    }
}

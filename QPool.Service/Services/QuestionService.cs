using QPool.Data.Interfaces;
using QPool.Data.Model;
using QPool.Service.Interfaces;
using QPool.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Service.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<IEnumerable<Question>> GetQuestionsByTechnologyIdAsync(int technologyId)
        {
            return await _questionRepository.GetQuestionsByTechnologyIdAsync(technologyId);
        }
        public async Task AddQuestionAsync(QuestionDto questionDto)
        {
            var question = new Question
            {
                TechnologyID = questionDto.TechnologyID,
                QuestionText = questionDto.QuestionText,
                Answer = questionDto.Answer
            };
            await _questionRepository.AddQuestionAsync(question);
        }
    }

}

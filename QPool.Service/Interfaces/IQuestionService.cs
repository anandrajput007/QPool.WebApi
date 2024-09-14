using QPool.Data.Model;
using QPool.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Service.Interfaces
{
    public interface IQuestionService
    {
        public Task<IEnumerable<Question>> GetQuestionsByTechnologyIdAsync(int technologyId);

        Task AddQuestionAsync(QuestionDto questionDto);
    }

}

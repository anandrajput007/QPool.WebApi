using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using QPool.Data.Interfaces;
using QPool.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Data.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly AppDbContext _context;

        public QuestionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Question>> GetQuestionsByTechnologyIdAsync(int technologyId)
        {
            return await _context.Questions
                .Where(q => q.TechnologyID == technologyId)
                .ToListAsync();
        }

        public async Task AddQuestionAsync(Question question)
        {
            // Serialize the question object to JSON
            var json = JsonConvert.SerializeObject(question);

            // Deserialize it back to handle special characters
            var sanitizedQuestion = JsonConvert.DeserializeObject<Question>(json);
            await _context.Questions.AddAsync(sanitizedQuestion);
            await _context.SaveChangesAsync();
        }
    }
}

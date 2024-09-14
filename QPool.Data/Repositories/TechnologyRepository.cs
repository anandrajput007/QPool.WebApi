using Microsoft.EntityFrameworkCore;
using QPool.Data.Interfaces;
using QPool.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Data.Repositories
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly AppDbContext _context;

        public TechnologyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Technology>> GetAllTechnologiesAsync()
        {
            return await _context.Technologies.ToListAsync();
        }

        public async Task<Technology> GetTechnologyWithQuestionsAsync(int id)
        {
            return await _context.Technologies
                .Include(t => t.Questions)
                .FirstOrDefaultAsync(t => t.TechnologyID == id);
        }
    }

}

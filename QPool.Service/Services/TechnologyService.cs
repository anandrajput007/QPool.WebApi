using QPool.Data.Interfaces;
using QPool.Data.Model;
using QPool.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Service.Services
{
    public class TechnologyService : ITechnologyService
    {
        private readonly ITechnologyRepository _technologyRepository;

        public TechnologyService(ITechnologyRepository technologyRepository)
        {
            _technologyRepository = technologyRepository;
        }

        public async Task<IEnumerable<Technology>> GetAllTechnologiesAsync()
        {
            return await _technologyRepository.GetAllTechnologiesAsync();
        }

        public async Task<Technology> GetTechnologyWithQuestionsAsync(int id)
        {
            return await _technologyRepository.GetTechnologyWithQuestionsAsync(id);
        }
    }

}

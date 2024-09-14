using QPool.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Service.Interfaces
{
    public interface ITechnologyService
    {
        public Task<IEnumerable<Technology>> GetAllTechnologiesAsync();
        public Task<Technology> GetTechnologyWithQuestionsAsync(int id);
    }

}

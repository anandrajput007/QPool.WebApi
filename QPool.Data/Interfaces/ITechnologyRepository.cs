using QPool.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Data.Interfaces
{
    public interface ITechnologyRepository
    {
        Task<IEnumerable<Technology>> GetAllTechnologiesAsync();
        Task<Technology> GetTechnologyWithQuestionsAsync(int id);
    }

}

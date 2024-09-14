using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Data.Model
{
    public class Technology
    {
        public int TechnologyID { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }
    }

}

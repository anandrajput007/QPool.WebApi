using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Shared.DTO
{
    public class QuestionDto
    {
        public int TechnologyID { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
    }
}

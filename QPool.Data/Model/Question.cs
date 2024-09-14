using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QPool.Data.Model
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int TechnologyID { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
        [JsonIgnore]
        public Technology Technology { get; set; }
    }

}

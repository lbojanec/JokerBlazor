using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokerBlazor.Models
{
    public class Question
    {
        public string c_IdQuestion { get; set; }
        public string c_QuestionText { get; set; }
        public bool c_IsCurrent { get; set; }
        public string c_IdType { get; set; }
        public string c_IdDifficulty { get; set; }
        public string c_IdCategory { get; set; }
        public string c_IdLanguage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokerBlazor.Models
{
    public class Answer
    {
        public string c_IdAnswer { get; set; }
        public string c_AnswerText { get; set; }
        public bool c_IsCorrect { get; set; }
        public string c_IdQuestion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLibrary
{
    public abstract class Question
    {
        public abstract int difficulty { get; set; }
        public abstract string answer { get; set; }
        public int[] difficultyRange { get; set; }
        
        public abstract string GetString();
        public abstract bool CheckAnswer(string answer);

    }
}

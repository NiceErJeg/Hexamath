using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLibrary.QuestionTypes
{
    public class SubtractionQuestion : MultipleChoiceQuestion
    {
        public override int difficulty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string answer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool CheckAnswer(string answer)
        {
            throw new NotImplementedException();
        }

        public override string[] GenerateFakeAnswers()
        {
            throw new NotImplementedException();
        }

        public override string GetString()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Globalization;

namespace QuestionLibrary.QuestionTypes
{
    public class AdditionQuestion : OpenAnswerQuestion
    {
        public override int difficulty { get; set; }
        public override string answer { get; set; }

        public override bool CheckAnswer(string answer)
        {
            return CompareAnswer(answer);
        }

        public override string GetString()
        {
            string returnString = GenerateQuestion();
            return returnString;
        }

        internal string GenerateQuestion()
        {
            string questionString = string.Empty;
            Random random = new Random();
            double Num1 = 0;
            double Num2 = 0;
            double Num3 = 0;
            switch (difficulty)
            {
                case 1:
                    Num1 = random.Next(1, 9);
                    Num2 = random.Next(1, 9);
                    answer = (Num1 + Num2).ToString();
                    questionString = Num1 + " + " + Num2;
                    break;
                case 2:
                    Num1 = random.Next(1, 99);
                    Num2 = random.Next(1, 99);
                    answer = (Num1 + Num2).ToString();
                    questionString = Num1 + " + " + Num2;
                    break;
                case 3:
                    Num1 = random.Next(10, 999) / 10;
                    Num2 = random.Next(10, 999) / 10;
                    answer = (Num1 + Num2).ToString();
                    questionString = Num1 + " + " + Num2;
                    break;
                case 4:
                    Num1 = random.Next(1000, 9999) / 100;
                    Num2 = random.Next(1000, 9999) / 100;
                    Num3 = random.Next(1000, 9999) / 100;
                    answer = (Num1 + Num2 + Num3).ToString();
                    questionString = Num1 + " + " + Num2 + " + " + Num3;
                    break;
            }
            return questionString;
        }

        internal bool CompareAnswer(string answer)
        {
            string tmpAnswer = answer.ToLower();
            double answerDouble = Convert.ToDouble(tmpAnswer, CultureInfo.InvariantCulture);
            if (Convert.ToDouble(this.answer) == answerDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

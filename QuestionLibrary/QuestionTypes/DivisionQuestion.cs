using System;
using System.Collections.Generic;
using System.Globalization;

namespace QuestionLibrary.QuestionTypes
{
    public class DivisionQuestion : MultipleChoiceQuestion
    {
        public override int difficulty { get; set; }
        public override string answer { get; set; }

        public override bool CheckAnswer(string answer)
        {
            return CompareAnswer(answer);
        }

        public override string[] GenerateFakeAnswers()
        {
            string[] returnStringArray = new string[3];
            string tmpAnswer = answer.ToLower();
            double answerDouble = Convert.ToDouble(tmpAnswer, CultureInfo.InvariantCulture);
            List<int> DoneFakeAnswers = new List<int>();
            Random random = new Random();
            while (DoneFakeAnswers.Count < 3)
            {
                switch (random.Next(0, 5))
                {
                    case 0:
                        if (!DoneFakeAnswers.Contains(0))
                        {
                            returnStringArray[DoneFakeAnswers.Count] = (answerDouble + random.Next(2, 5)).ToString();
                        }
                        break;
                    case 1:
                        if (!DoneFakeAnswers.Contains(1))
                        {
                            returnStringArray[DoneFakeAnswers.Count] = (answerDouble - random.Next(2, 5)).ToString();
                        }
                        break;
                    case 2:
                        if (!DoneFakeAnswers.Contains(2))
                        {
                            returnStringArray[DoneFakeAnswers.Count] = (answerDouble + (random.Next(11, 99) / 10)).ToString();
                        }
                        break;
                    case 3:
                        if (!DoneFakeAnswers.Contains(3))
                        {
                            returnStringArray[DoneFakeAnswers.Count] = (answerDouble * 2 + random.Next(2, 5)).ToString();
                        }
                        break;
                    case 4:
                        if (!DoneFakeAnswers.Contains(4))
                        {
                            returnStringArray[DoneFakeAnswers.Count] = (answerDouble * 2 - random.Next(2, 5)).ToString();
                        }
                        break;
                    case 5:
                        if (!DoneFakeAnswers.Contains(5))
                        {
                            returnStringArray[DoneFakeAnswers.Count] = (answerDouble + (random.Next(11, 99) / 10)).ToString();
                        }
                        break;
                }
            }

            return returnStringArray;
        }

        public override string GetString()
        {
            return GenerateQuestion();
        }
        internal string GenerateQuestion()
        {
            string questionString = string.Empty;
            Random random = new Random();
            double Num1 = 0;
            double Num2 = 0;
            switch (difficulty)
            {
                case 3:
                    Num2 = random.Next(2, 9);
                    Num1 = Num2 * random.Next(1, 9);
                    answer = (Num1 / Num2).ToString();
                    questionString = Num1 + " / " + Num2;
                    break;
                case 4:
                    Num2 = random.Next(1, 99);
                    Num1 = Num2 * random.Next(1, 99);
                    answer = (Num1 / Num2).ToString();
                    questionString = Num1 + " / " + Num2;
                    break;
                case 5:
                    Num2 = random.Next(10, 999) / 10;
                    Num1 = Num2 * (random.Next(10, 999) / 10);
                    answer = (Num1 + Num2).ToString();
                    questionString = Num1 + " + " + Num2;
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

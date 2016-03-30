using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Evaluator
    {
        private const string answerQuestion1 = "arpanet";
        private const int answerQuestion2 = 0;
        private const int answerQuestion4 = 1;
        private const int answerQuestion5 = 1;
        private const string answerQuestion6 = "1. 1. 1970";

        public int CorrectAnswers { get; set; }

        public bool evaluateAnswer1(string answer)
        {
            return checkCorrect(answer.Trim().ToLower().CompareTo(answerQuestion1) == 0);
        }

        public bool evaluateAnswer2(bool[] answer)
        {
            return checkCorrect(answer[answerQuestion2]);
        }

        public bool evaluateAnswer3(bool[] answer)
        {
            return checkCorrect(answer[0] == false && answer[1] == true && answer[2] == true && answer[3] == false);
        }

        public bool evaluateAnswer4(bool[] answer)
        {
            return checkCorrect(answer[answerQuestion4]);
        }

        public bool evaluateAnswer5(int answerPosition)
        {
            return checkCorrect(answerQuestion5 == answerPosition);
        }

        public bool evaluateAnswer6(string answer)
        {
            return checkCorrect(answerQuestion6.CompareTo(answer) == 0);
        }

        private bool checkCorrect(bool answer)
        {
            if (answer)
            {
                CorrectAnswers++;
                return true;
            }

            return false;
        }
    }
}

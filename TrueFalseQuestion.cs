using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion()
        {

        }
        public TrueFalseQuestion(string header, string body, int mark, Answer[] answers, Answer rightAnswers) : base(header, body, mark)
        {
            Answers = answers;
            RightAnswer = rightAnswers;
        }
        public override void ShowQuestion()
        {
            Console.WriteLine(Header);

            Console.WriteLine(Body);

            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}

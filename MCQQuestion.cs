using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion()
        {

        }

        public MCQQuestion(string header, string body, int mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark)
        {
            Answers = answers;
            RightAnswer = rightAnswer;
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

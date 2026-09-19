using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Exam
{
    internal class PracticalExam:Exam
    {
        public PracticalExam()
        {

        }
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {

        }
        public override void ShowExam()
        {

            Stopwatch sw = new Stopwatch();
            int grade = 0;
            Console.WriteLine("============ PracticalExam ============");

            Console.WriteLine($"Time : {Time} Minutes");

            Console.WriteLine($"Number Of Questions : {NumberOfQuestions} ");

            Console.WriteLine();

            sw.Start();

            foreach (Question question in Questions)
            {
                question.ShowQuestion();

                Console.WriteLine("Enter your answer : ");

                int userAnswer = int.Parse(Console.ReadLine());
                if (question.RightAnswer != null && userAnswer == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }

                Console.WriteLine();

            }
            sw.Stop();

            Console.WriteLine("============ Correct Answers ============");

            foreach (Question question in Questions)
            {
                Console.WriteLine($"{question.Header}:{question.RightAnswer.AnswerText}");

            }

            Console.WriteLine("============ Exam Finished ============");

            Console.WriteLine();

            Console.WriteLine($"Your Grade = {grade}");

            Console.WriteLine($"Time Taken : {sw.Elapsed}");
            Console.WriteLine();
            Console.WriteLine("Thank you");


        }
    }
}

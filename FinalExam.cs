using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Timers;

namespace Exam
{
    internal class FinalExam :Exam
    {
        public FinalExam()
        {

        }
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {

        }

        public override void ShowExam()
        {
            Stopwatch sw = new Stopwatch();
            int grade = 0;
            Console.WriteLine("============ FinalExam ============");

            Console.WriteLine($"Time:{Time} Minutes");

            Console.WriteLine($"Number Of Questions : {NumberOfQuestions}");

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


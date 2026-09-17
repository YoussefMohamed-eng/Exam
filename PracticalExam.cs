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
            Console.WriteLine("============ PracticalExam ============");

            Console.WriteLine($"Time : {Time} Minutes");

            Console.WriteLine($"Number Of Questions : {NumberOfQuestions} ");

            Console.WriteLine();

            sw.Start();

            foreach (Question question in Questions)
            {
                question.ShowQuestion();

                Console.WriteLine("Enter your answer : ");

                Console.ReadLine();

                Console.WriteLine();

            }
            sw.Stop();

            Console.WriteLine("============ Exam Finished ============");
            Console.WriteLine($"Time Taken : {sw.Elapsed.Minutes} Minutes {sw.Elapsed.Seconds} Seconds");

            Console.WriteLine("============ Correct Answers ============");

            foreach (Question question in Questions)
            {
                Console.WriteLine($"{question.Header}:{question.RightAnswer.AnswerText}");

            }

        }
    }
}

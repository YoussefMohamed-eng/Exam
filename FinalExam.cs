using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Timers;

namespace Exam
{

    internal class FinalExam : Exam
    {
        public FinalExam()
        {
        }

        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Stopwatch stopwatch = new Stopwatch();

            int grade = 0;
            int totalMarks = 0;

            Console.WriteLine("Final Exam");
            Console.WriteLine();

            stopwatch.Start();

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine(
                    $"Question {i + 1}: {question.Header}");

                Console.WriteLine(
                    $"{question.Body}");

                Console.WriteLine(
                    $"MCQ Question:     Mark {question.Mark}");

                foreach (Answer answer in question.Answers)
                {
                    Console.WriteLine(
                        $"{answer.AnswerId}- {answer.AnswerText}");
                }

                Console.Write("Enter your answer ID: ");

                int userAnswer = int.Parse(Console.ReadLine());

                Answer selectedAnswer =
                    question.Answers[userAnswer - 1];

                Console.WriteLine(
                    $"Your Answer => {selectedAnswer.AnswerText}");


                Console.WriteLine(
                    $"Correct Answer => {question.RightAnswer.AnswerText}");

                totalMarks += question.Mark;

                if (userAnswer == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }

                Console.WriteLine();
            }

            stopwatch.Stop();

            Console.WriteLine("================================");
            Console.WriteLine();

            Console.WriteLine(
                $"Your Grade is {grade} from {totalMarks}");

            Console.WriteLine(
                $"Time = {stopwatch.Elapsed:hh\\:mm\\:ss}");

            Console.WriteLine();
            Console.WriteLine("Thank you");
        }
    }
}
        
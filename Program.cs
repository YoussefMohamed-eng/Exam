namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exam
            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(subjectId, subjectName);

            Console.WriteLine("\nChoose Exam Type:");
            Console.WriteLine("1. Final Exam");
            Console.WriteLine("2. Practical Exam");
            Console.Write("Enter Choice: ");

            int examType = int.Parse(Console.ReadLine());

            Console.Write("\nEnter Exam Time in Minutes: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Exam exam;

            if (examType == 1)
            {
                exam = new FinalExam(time, numberOfQuestions);
            }
            else
            {
                exam = new PracticalExam(time, numberOfQuestions);
            }

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"\n========== Question {i + 1} ==========");

                Console.Write("Enter Question Type (1 = True/False, 2 = MCQ): ");
                int questionType = int.Parse(Console.ReadLine());

                Console.Write("Enter Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Mark: ");
                int mark = int.Parse(Console.ReadLine());

                Console.Write("Enter Number of Answers: ");
                int numberOfAnswers = int.Parse(Console.ReadLine());

                Answer[] answers = new Answer[numberOfAnswers];

                for (int j = 0; j < numberOfAnswers; j++)
                {
                    Console.Write($"Enter Answer {j + 1}: ");
                    string answerText = Console.ReadLine();

                    answers[j] = new Answer(j + 1, answerText);
                }

                Console.Write("Enter Right Answer ID: ");
                int rightAnswerId = int.Parse(Console.ReadLine());

                Answer rightAnswer = answers[rightAnswerId - 1];

                if (questionType == 1)
                {
                    exam.Questions[i] =
                        new TrueFalseQuestion(
                            header,
                            body,
                            mark,
                            answers,
                            rightAnswer
                        );
                }
                else
                {
                    exam.Questions[i] =
                        new MCQQuestion(
                            header,
                            body,
                            mark,
                            answers,
                            rightAnswer
                        );
                }
            }

            subject.CreateExam(exam);

            Console.Clear();

            Console.WriteLine($"Subject: {subject.SubjectName}");
            Console.WriteLine();

            subject.Exam.ShowExam();

            Console.ReadKey();

            #endregion
        }
    }
}

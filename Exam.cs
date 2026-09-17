using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    internal abstract class Exam
    {
        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        protected Exam()
        {

        }
        protected Exam(int time, int numberOfQuestions)

        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;

            Questions = new Question[NumberOfQuestions];
        }
        public abstract void ShowExam();
    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    internal class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public Exam Exam { get; set; }

        public Subject()
        {

        }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;

            SubjectName = subjectName;
        }
        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public override string ToString()
        {
            return $"{SubjectId}-{SubjectName}";
        }

    }
}

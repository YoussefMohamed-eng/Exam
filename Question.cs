using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    internal abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark { get; set; }

        public Answer[] Answers { get; set; }

        public Answer RightAnswer { get; set; }

        protected Question()
        {

        }
        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }
        public abstract void ShowQuestion();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(Question other)
        {
            if (other == null)
                return 1;
            return Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"{Header}: {Body} -Mark = {Mark}";
        }

    }


}

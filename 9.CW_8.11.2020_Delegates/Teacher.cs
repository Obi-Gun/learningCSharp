using System;
using System.Collections.Generic;
using System.Text;

namespace _9.CW_8._11._2020_Delegates
{
    public class Teacher : IHuman
    {
        public event ExamDelegate ExamEvent;

        public EventHandler<ExamEventArgs> ExamEvent2;

        public void Exam(string task)
        {
            if (ExamEvent != null)
            {
                ExamEvent(task);
            }
        }

        public void Exam(ExamEventArgs task)
        {
            if (ExamEvent2 != null)
            {
                ExamEvent2(this, task);
            }
        }
    }
}

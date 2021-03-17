using System;
using System.Collections.Generic;
using System.Text;

namespace _9.CW_8._11._2020_Delegates
{
    public class Student : IHuman
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GroupId { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public void Exam(string task)
        {
            Console.WriteLine($"Student {LastName} solved the { task}");
        }

        public void Exam(object sender, ExamEventArgs e)
        {
            Console.WriteLine($"Student {LastName} solved the {e.Task}");
        }
    }
}

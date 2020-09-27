using System;
using System.Collections.Generic;
using System.Text;

namespace learningCSharp
{
    class Student
    {
        public readonly string _typeSpecies;
        private int _studentID = 0;
        private string _firstName = "none";
        private string _lastName = "none";
        private int _group = 0;

        public Student()
        {
        }

        public Student(int studentID, string firstName, string lastName, int group) 
        {
            _studentID = studentID;
            _firstName = firstName;
            _lastName = lastName;
            _group = group;
            _typeSpecies = "Human";
        }

        public void Print()
        {
            Console.WriteLine($"{_studentID} {_firstName} {_lastName} {_group}");
        }
    }
}

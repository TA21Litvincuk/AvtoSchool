using System;
using DrivingSchool.Interfaces;

namespace DrivingSchool.Models
{
    public class Student : IPerson
    {
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Level { get; set; }

        public Student(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Level = "Beginner";
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, I am {Name}, a student.");
        }
    }
}

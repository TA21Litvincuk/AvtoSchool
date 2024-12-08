using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrivingSchool.Interfaces;

namespace DrivingSchool.Models
{
    public class Instructor : IPerson
    {
        public string Name { get; private set; }
        public int Experience { get; private set; }
        public string Category { get; private set; }

        public Instructor(string name, int experience, string category)
        {
            Name = name;
            Experience = experience;
            Category = category;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, I am {Name}, an instructor with {Experience} years of experience.");
        }
    }
}


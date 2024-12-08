using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrivingSchool.Interfaces;

namespace DrivingSchool.Models
{
    public class AdvancedInstructor : Instructor, IPerson
    {
        public AdvancedInstructor(string name, int experience, string category)
            : base(name, experience, category) { }

        // Явна реалізація інтерфейсу IPerson
        void IPerson.Introduce()
        {
            Console.WriteLine($"(Explicit) Hello, I am {Name}, an advanced instructor with {Experience} years of experience.");
        }
    }
}

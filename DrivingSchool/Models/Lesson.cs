using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace DrivingSchool.Models
{
    public class Lesson
    {
        public Student Student { get; private set; }
        public Instructor Instructor { get; private set; }
        public Car Car { get; private set; }
        public DateTime LessonDate { get; private set; }

        public Lesson(Student student, Instructor instructor, Car car, DateTime lessonDate)
        {
            Student = student;
            Instructor = instructor;
            Car = car;
            LessonDate = lessonDate;
        }

        public void StartLesson()
        {
            Console.WriteLine($"Lesson started for {Student.Name} with instructor {Instructor.Name} on {Car.Brand} {Car.Model}.");
        }
    }
}

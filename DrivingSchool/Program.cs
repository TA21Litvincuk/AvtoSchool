using System;
using DrivingSchool.Interfaces;
using DrivingSchool.Models;
using DrivingSchool.Services;

namespace DrivingSchool
{
    class Program
    {
        static void Main()
        {
            var student = new Student("John Doe", new DateTime(2000, 5, 15));
            var instructor = new Instructor("Jane Smith", 10, "B");
            var car = new Car("Toyota", "Corolla", "Automatic");
            var lesson = new Lesson(student, instructor, car, DateTime.Now);

            student.Introduce();
            instructor.Introduce();
            car.StartEngine();
            lesson.StartLesson();

            var advancedInstructor = new AdvancedInstructor("Mark Johnson", 15, "A");
            ((IPerson)advancedInstructor).Introduce();

            var lessonWithEvent = new LessonWithEvent(student, instructor, car, DateTime.Now);
            lessonWithEvent.LessonCompleted += message => Console.WriteLine(message);
            lessonWithEvent.CompleteLesson();

            var studentRepo = new Repository<Student>();
            studentRepo.Add(student);
            foreach (var s in studentRepo.GetAll())
                Console.WriteLine(s.Name);
        }
    }
}


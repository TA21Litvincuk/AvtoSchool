using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DrivingSchool.Models
{
    public delegate void LessonCompletedHandler(string message);

    public class LessonWithEvent : Lesson
    {
        public event LessonCompletedHandler LessonCompleted;

        public LessonWithEvent(Student student, Instructor instructor, Car car, DateTime lessonDate)
            : base(student, instructor, car, lessonDate) { }

        public void CompleteLesson()
        {
            LessonCompleted?.Invoke($"Lesson for {Student.Name} completed successfully!");
        }
    }
}

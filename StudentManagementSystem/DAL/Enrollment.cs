using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    class Enrollment
    {

        static List<Enrollment> enrollments = new List<Enrollment>();
        static List<Student> students = new List<Student>();
        static List<Course> courses = new List<Course>();

        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }


        // Method to view all enrollments
        public void ViewEnrollments()
        {
            
            foreach (var enrollment in enrollments)
            {
                var student = students.Find(s => s.StudentId == enrollment.StudentId);
                var course = courses.Find(c => c.CourseId == enrollment.CourseId);
                Console.WriteLine($"Enrollment ID: {enrollment.EnrollmentId}, Student: {student?.Name}, Course: {course?.Title}, Grade: {enrollment.Grade}");
            }
        }
    }
}

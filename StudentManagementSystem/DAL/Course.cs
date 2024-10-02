using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    class Course
    {
        List<Course> courses = new List<Course>();
        List<Enrollment> enrollments = new List<Enrollment>();
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }


        // Method to view all courses
        public void ViewCourses()
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.CourseId}, Title: {course.Title}, Credits: {course.Credits}");
            }
        }

        // Method to add a new course
        public void AddCourse()
        {
            Console.WriteLine("Enter Course ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Course Credits:");
            int credits = int.Parse(Console.ReadLine());

            // Add the new course to the list
            courses.Add(new Course { CourseId = id, Title = title, Credits = credits });
        }

        // Method to enroll a student in a course
        public void EnrollStudent()
        {
            Console.WriteLine("Enter Enrollment ID:");
            int enrollmentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student ID:");
            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course ID:");
            int courseId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Grade:");
            string grade = Console.ReadLine();

            // Add the new enrollment to the list
            enrollments.Add(new Enrollment { EnrollmentId = enrollmentId, StudentId = studentId, CourseId = courseId, Grade = grade });
        }

    }
}

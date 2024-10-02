using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem.DAL;
using StudentManagementSystem.BAL;

namespace StudentManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            Instructor instructor = new Instructor();
            Course course = new Course();
            Enrollment enrollment = new Enrollment();
            StudentServices studentServices = new StudentServices();

            while (true)
            {
                Console.WriteLine("Student Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Add Instructor");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. View Students");
                Console.WriteLine("6. View Courses");
                Console.WriteLine("7. View Instructors");
                Console.WriteLine("8. View Enrollments");
                Console.WriteLine("9. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                // Switch case to handle different menu options
                switch (option)
                {
                    case 1:
                        studentServices.AddStudent();
                        break;
                    case 2:
                        course.AddCourse();
                        break;
                    case 3:
                        instructor.AddInstructor();
                        break;
                    case 4:
                        course.EnrollStudent();
                        break;
                    case 5:
                        studentServices.ViewStudents();
                        break;
                    case 6:
                        course.ViewCourses();
                        break;
                    case 7:
                        instructor.ViewInstructors();
                        break;
                    case 8:
                        enrollment.ViewEnrollments();
                        break;
                    case 9:
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

       
    }
}

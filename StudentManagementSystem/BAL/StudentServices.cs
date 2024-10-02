using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem.DAL;

namespace StudentManagementSystem.BAL
{

    internal class StudentServices : Student
    {
        static List<Student> students = new List<Student>();

        // Method to view all students
        public void ViewStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
            }
        }


        public void AddStudent()
        {
            Console.WriteLine("Enter Student ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Email:");
            string email = Console.ReadLine();

            // Add the new student to the list
            students.Add(new Student { StudentId = id, Name = name, Age = age, Email = email });
            
        }
    }
}

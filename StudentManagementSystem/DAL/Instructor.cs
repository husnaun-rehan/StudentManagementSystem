using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    class Instructor
    {

        static List<Instructor> instructors = new List<Instructor>();


        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }



        // Method to view all instructors
        public void ViewInstructors()
        {

            foreach (var instructor in instructors)
            {
                Console.WriteLine($"ID: {instructor.InstructorId}, Name: {instructor.Name}, Department: {instructor.Department}");
            }
        }

        // Method to add a new instructor
        public void AddInstructor()
        {
            Console.WriteLine("Enter Instructor ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Instructor Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Instructor Department:");
            string department = Console.ReadLine();

            // Add the new instructor to the list
            instructors.Add(new Instructor { InstructorId = id, Name = name, Department = department });
        }
    }
}

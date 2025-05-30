using System;

namespace StudentEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create a new Student object
                var student = new Student()
                {
                    StudentName = "John Doe"
                };

                // Add student to the database
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadLine();
        }
    }
}

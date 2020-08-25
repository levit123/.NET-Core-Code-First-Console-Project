using System;

namespace EntityFramework_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            // uses SchoolContext to create a default set of students to initially populate the database with
            using (var ctx = new SchoolContext())
            {
                // creates and defines three Student objects
                var stud1 = new Student() { StudentName = "Billy" };
                var stud2 = new Student() { StudentName = "Sally" };
                var stud3 = new Student() { StudentName = "Mandy" };

                // adds the Student objects to the SchoolContext
                ctx.Students.Add(stud1);
                ctx.Students.Add(stud2);
                ctx.Students.Add(stud3);

                ctx.SaveChanges();

                foreach (var stud in ctx.Students)
                {
                    Console.WriteLine("Student ID: " + stud.StudentID + " Student Name: " + stud.StudentName);
                }
            }
        }
    }
}

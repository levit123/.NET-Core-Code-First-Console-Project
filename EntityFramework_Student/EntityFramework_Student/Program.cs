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
                var stud1 = new Student() { StudentName = "Billy", DateOfBirth = new DateTime(year: 1998, month: 3, day: 12), Height = 5.6m, Weight = 150 };
                var stud2 = new Student() { StudentName = "Sally", DateOfBirth = new DateTime(year: 1995, month: 6, day: 10), Height = 5.9m, Weight = 165 };
                var stud3 = new Student() { StudentName = "Mandy", DateOfBirth = new DateTime(year: 1990, month: 10, day: 6), Height = 5.2m, Weight = 156 };

                // adds the Student objects to the SchoolContext
                ctx.Students.Add(stud1);
                ctx.Students.Add(stud2);
                ctx.Students.Add(stud3);

                ctx.SaveChanges();

                foreach (var stud in ctx.Students)
                {
                    Console.WriteLine("Student ID: " + stud.StudentID + " Student Name: " + stud.StudentName + " Date Of Birth: " + stud.DateOfBirth + " Height: " + stud.Height + " feet "
                        + "Weight: " + stud.Weight + " lbs");
                }
            }
        }
    }
}

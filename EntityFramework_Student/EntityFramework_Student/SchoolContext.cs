using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EntityFramework_Student
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());
        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}

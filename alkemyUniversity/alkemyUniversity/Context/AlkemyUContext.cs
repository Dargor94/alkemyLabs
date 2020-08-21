using alkemyUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace alkemyUniversity.Context
{
    public class AlkemyUContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Lecturer> lecturers { get; set; }
        public DbSet<Person> people { get; set; }
        public DbSet<Student> students { get; set; }

        public AlkemyUContext() : base("AlkemyLabs")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AlkemyUContext>());
        }

    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace W26W9CodeFirstApproach
{
    // context class
    public class SchoolContext : DbContext
    {
        // connection string - REQUIRED
        // read the conn str from the App.config file
        // override the OnConfiguring method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = ConfigurationManager.ConnectionStrings["School"].ConnectionString;
            optionsBuilder.UseSqlServer(connStr);
        }


        // define entity sets - REQUIRED
        // use DbSet properties
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }


        // data seeding - OPTIONAL
        // override the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>().HasData(
                new Standard { StandardId = 1, StandardName = "Standard 1" },
                new Standard { StandardId = 2, StandardName = "Standard 2" },
                new Standard { StandardId = 3, StandardName = "Standard 3" },
                new Standard { StandardId = 4, StandardName = "Standard 4" },
                new Standard { StandardId = 5, StandardName = "Standard 5" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "John", StandardId = 1 },
                new Student { StudentId = 2, StudentName = "Mark", StandardId = 1 },
                new Student { StudentId = 3, StudentName = "Anne", StandardId = 2 },
                new Student { StudentId = 4, StudentName = "Alice", StandardId = 4 }
            );
        }
    }
}

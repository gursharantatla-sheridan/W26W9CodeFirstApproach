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

    }
}

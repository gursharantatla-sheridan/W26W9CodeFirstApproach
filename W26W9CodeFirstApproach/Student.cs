using System;
using System.Collections.Generic;
using System.Text;

namespace W26W9CodeFirstApproach
{
    public class Student
    {
        // scalar properties
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int? StandardId { get; set; }

        // navigation property
        public Standard? Standard { get; set; }
    }
}

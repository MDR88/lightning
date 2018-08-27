using System;
using System.Collections.Generic;


// Create a `Cohort` class that..

namespace Lightning
{

    public class Cohort
    {
        // 1. Maintains a list of students

        public List<Student> StudentList = new List<Student>();

        // 2. Maintains a list of instructors
        public List<Instructor> InstructorList = new List<Instructor>();

    // 3. Has a property of the cohort number
        public int Number { get; set; }
    }
}

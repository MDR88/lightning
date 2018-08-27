using System;
using System.Collections.Generic;


//Create some cohorts, students, and instructors in your `Program.cs`
namespace Lightning
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort26 = new Cohort();

            Instructor steve = new Instructor("Steve", "Brownlee");

            Student jewel = new Student("Jewel", "Ramirez");


            //and assign the students and instructors to the cohort
            cohort26.InstructorList.Add(steve);
            cohort26.StudentList.Add(jewel);

            // 1. Create some exercises
            // 2. Write a method on the `Instructor` 
            //class that will allow you to assign an individual exercise to an individual student

            Exercise ex1 = new Exercise();
            ex1.Name = "ChickenMonkey";
            ex1.Language = "JavaScript";
            ex1.GithubUrl = "www.github.com";

            Exercise ex2 = new Exercise()
            {
                Name = "KillHanson",
                Language = "C#",
                GithubUrl = "www.github.com"
            };
            System.Console.WriteLine(ex2.Name);

            //Pick one of the students and write to the Console each exercise that has been assigned to that student
            steve.AssignExercise(jewel, ex1);
            steve.AssignExercise(jewel, ex2);

            foreach (Exercise exercise in jewel.AssignedExercises)
            {
                Console.WriteLine($"{jewel.Name}: {exercise.Name}");

            }

        }
    }
}



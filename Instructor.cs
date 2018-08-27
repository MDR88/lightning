using System;
using System.Collections.Generic;


//Create a `Student` class with the following properties and fields
//         1. private fields for first name and last name



// 4. A public list of exercises

namespace Lightning
{


    public class Instructor : Person
    {
        // private string _firstName;
        // private string _lastName;


        // Defining the get method. // 2. Public calculated property that returns "Firstname Lastname" of student
        // public string Name { get => $"{_firstName} {_lastName}"; }

        //public List<Exercise> AssignedExercises {get;} = new List<Exercise>();

        // 3. Constructor that accepts first name and last name
        public Instructor(string firstName, string lastName)
        {

            _firstName = firstName;
            _lastName = lastName;

        }
        public void AssignExercise(Student student, Exercise exercise)
        {

            student.AssignedExercises.Add(exercise);
        }

    }
}
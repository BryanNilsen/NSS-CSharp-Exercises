using System;
using System.Collections.Generic;
using System.Linq;
namespace StudentExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create 4, or more, exercises.
      Exercise chickenMonkey = new Exercise("Chicken Monkey", "JavaScript");
      Exercise christmasTree = new Exercise("Christmas Tree", "JavaScript");
      Exercise heist = new Exercise("The Heist", "C#");
      Exercise kennel = new Exercise("Kennel", "React");
      Exercise flexboxFroggy = new Exercise("Flexbox Froggy", "CSS");

      // Create 3, or more, cohorts.
      Cohort c34 = new Cohort("Cohort 34");
      Cohort c35 = new Cohort("Cohort 35");
      Cohort c36 = new Cohort("Cohort 36");

      // Create 4, or more, students and assign them to one of the cohorts.
      Student bitoM = new Student("Bito", "Mann");
      c36.AssignStudent(bitoM);

      Student jamesM = new Student("James", "McClarty");
      c35.AssignStudent(jamesM);

      Student noahB = new Student("Noah", "Barfield");
      c34.AssignStudent(noahB);

      Student bobbyB = new Student("Bobby", "Brady");
      c34.AssignStudent(bobbyB);

      Student ellieA = new Student("Ellie", "Ash");
      c34.AssignStudent(ellieA);

      Student brantleyJ = new Student("Brantley", "Jones");
      c34.AssignStudent(brantleyJ);

      // Create 3, or more, instructors and assign them to one of the cohorts.
      Instructor andyC = new Instructor("Andy", "Collins");
      c34.AssignInstructor(andyC);

      Instructor adamS = new Instructor("Adam", "Sheaffer");
      c34.AssignInstructor(adamS);

      Instructor bryanN = new Instructor("Bryan", "Nilsen");
      c34.AssignInstructor(bryanN);


      // Have each instructor assign 2 exercises to each of the students.
      andyC.AssignExercise(noahB, heist);
      andyC.AssignExercise(ellieA, kennel);
      bryanN.AssignExercise(noahB, flexboxFroggy);
      bryanN.AssignExercise(bobbyB, flexboxFroggy);
      adamS.AssignExercise(bobbyB, kennel);
      adamS.AssignExercise(brantleyJ, chickenMonkey);
      adamS.AssignExercise(brantleyJ, flexboxFroggy);
      adamS.AssignExercise(brantleyJ, kennel);
      adamS.AssignExercise(brantleyJ, christmasTree);


      Console.WriteLine($"{c34.Name} Students:");
      foreach (Student student in c34.Students)
      {
        Console.WriteLine(student.FirstName);
        foreach (Exercise exercise in student.Exercises)
        {
          Console.WriteLine($" - {exercise.Name} / ({exercise.Language})");
        }
        Console.WriteLine("");
      }

      List<Student> students = new List<Student>() {
          brantleyJ,
          noahB,
          ellieA,
          bobbyB,
          jamesM,
          bitoM
      };

      List<Exercise> exercises = new List<Exercise>() {
          chickenMonkey,
          christmasTree,
          heist,
          kennel,
          flexboxFroggy
      };

      List<Instructor> instructors = new List<Instructor> {
        andyC,
        adamS,
        bryanN
      };

      List<Cohort> cohorts = new List<Cohort> {
        c34,
        c35,
        c36
      };

      // List exercises for the JavaScript language by using the Where() LINQ method.
      var jsExercises = exercises.Where(exercise => exercise.Language == "JavaScript");
      Console.WriteLine("JS Exercises:");
      foreach (Exercise ex in jsExercises)
      {
        Console.WriteLine(ex.Name);
      }

      // List students in a particular cohort by using the Where() LINQ method.
      var c34Students = students.Where(student => student.Cohort == c34);
      // less expensive to just iterate over c34.Students

      // List instructors in a particular cohort by using the Where() LINQ method.
      var c34Instructors = instructors.Where(instructor => instructor.Cohort == c34);

      // Sort the students by their last name.
      var orderedStudents = students.OrderBy(student => student.LastName);

      // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
      var boredStudents = students.Where(student => student.Exercises.Count == 0);

      // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
      var exhaustedStudent = students.OrderBy(student => student.Exercises.Count).Last();
      // alternatively
      var exhaustedStudent2 = students.OrderByDescending(student => student.Exercises.Count).First();

      // How many students in each cohort?
      Console.WriteLine("COHORT STUDENT COUNT");
      foreach (Cohort cohort in cohorts)
      {
        string studentPlural = cohort.Students.Count > 1 ? "students" : "student";
        Console.WriteLine("{0}: {1} {2}", cohort.Name, cohort.Students.Count, studentPlural);
      }
    }
  }
}


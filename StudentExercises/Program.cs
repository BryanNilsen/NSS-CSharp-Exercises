using System;

namespace StudentExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create 4, or more, exercises.
      Exercise chickenMonkey = new Exercise("Chicken Monkey", "JavaScript");
      Exercise heist = new Exercise("The Heist", "C#");
      Exercise kennel = new Exercise("Kennel", "React");
      Exercise flexboxFroggy = new Exercise("Flexbox Froggy", "CSS");

      // Create 3, or more, cohorts.
      Cohort c34 = new Cohort("Cohort 34");
      Cohort c35 = new Cohort("Cohort 35");
      Cohort c36 = new Cohort("Cohort 36");

      // Create 4, or more, students and assign them to one of the cohorts.
      Student noahB = new Student("Noah", "Barfield");
      c34.Students.Add(noahB);

      Student bobbyB = new Student("Bobby", "Brady");
      c34.Students.Add(bobbyB);

      Student ellieA = new Student("Ellie", "Ash");
      c34.Students.Add(ellieA);

      Student brantleyJ = new Student("Brantley", "Jones");
      c34.Students.Add(brantleyJ);

      // Create 3, or more, instructors and assign them to one of the cohorts.
      Instructor andyC = new Instructor("Andy", "Collins");
      c34.Instructors.Add(andyC);

      Instructor adamS = new Instructor("Adam", "Sheaffer");
      c34.Instructors.Add(adamS);

      Instructor bryanN = new Instructor("Bryan", "Nilsen");
      c34.Instructors.Add(bryanN);


      // Have each instructor assign 2 exercises to each of the students.
      andyC.AssignExercise(noahB, heist);
      andyC.AssignExercise(ellieA, kennel);
      bryanN.AssignExercise(noahB, flexboxFroggy);
      bryanN.AssignExercise(bobbyB, flexboxFroggy);
      adamS.AssignExercise(bobbyB, kennel);
      adamS.AssignExercise(brantleyJ, chickenMonkey);


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
    }
  }
}


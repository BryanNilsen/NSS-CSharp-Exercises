using System.Collections.Generic;

namespace StudentExercises
{
  class Instructor
  {
    public Instructor(string first, string last)
    {
      FirstName = first;
      LastName = last;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public string Cohort { get; set; }

    public string Specialty { get; set; }

    public void AssignExercise(Student student, Exercise exercise)
    {
      student.Exercises.Add(exercise);
    }


  }
}
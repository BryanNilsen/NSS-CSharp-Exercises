using System.Collections.Generic;

namespace StudentExercises
{
  class Student
  {
    public Student(string firstname, string lastname)
    {
      FirstName = firstname;
      LastName = lastname;
      Exercises = new List<Exercise>();
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort Cohort { get; set; }

    public List<Exercise> Exercises { get; set; }

  }
}
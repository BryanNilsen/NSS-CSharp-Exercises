using System.Collections.Generic;

namespace StudentExercises
{
  class Cohort
  {
    public Cohort(string name)
    {
      Name = name;
      Students = new List<Student>();
      Instructors = new List<Instructor>();
    }
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public List<Instructor> Instructors { get; set; }
  }
}
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

    public void AssignStudent(Student student)
    {
      Students.Add(student);
      student.Cohort = this;
    }
    public void AssignInstructor(Instructor instructor)
    {
      Instructors.Add(instructor);
      instructor.Cohort = this;
    }
  }
}
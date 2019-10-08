using System;
using System.Collections.Generic;

namespace classes_employees
{
  public class Company
  {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> employeeList = new List<Employee>();

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company(string name, DateTime date)
    {
      Name = name;
      CreatedOn = date;
    }
  }

  public class Employee
  {
    private DateTime _startDate;

    public Employee(string name)
    {
      FirstName = name;
    }
    public string FirstName { get; set; }
    public string Title { get; set; }
    public DateTime StartDate
    {
      get
      {
        return _startDate;
      }
      set
      {
        if (value > DateTime.Today)
        {
          _startDate = value;
        }
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Company company1 = new Company("Arby's", DateTime.Today);
      // Create an instance of a company. Name it whatever you like.
      Console.WriteLine(company1.Name);
      Console.WriteLine(company1.CreatedOn);

      // Create three employees
      Employee employee1 = new Employee("Bryan");
      employee1.Title = "Manager";

      Console.WriteLine(employee1.FirstName);
      // Assign the employees to the company

      /*
          Iterate the company's employee list and generate the
          simple report shown above
      */
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> nums = new List<int>
      {
        1, 2, 3, 4, 23, 55, 66, 13, 77, 88, 6, 99, 103
      };

      // Find for find in javascript
      int foundNum = nums.Find(n => n == 93);

      // Where for filter in javascript
      List<int> filteredNums = nums.Where(n => n < 60).ToList();

      // OrderBy for sort in javascript
      List<int> orderedAndFilteredNums = nums
        .Where(n => n < 60)
        .OrderBy(n => n)
        .ToList();

      // Alternatives to reduce in javascript
      int sum = nums.Sum();
      int smallest = nums.Min();
      int largest = nums.Max();
      double mean = nums.Average();

      // Select for map in javascript
      List<int> doubled = nums.Select(num => num * 2).ToList();
      List<string> stringedNums = nums.Select(num =>
        {
          return num.ToString();
        })
        .ToList();


      // LINQ Query syntax
      List<int> cohortStudentCount = new List<int>()
        {
            25, 12, 28, 22, 11, 25, 27, 24, 19
        };
      Console.WriteLine($"Largest cohort was {cohortStudentCount.Max()}");
      Console.WriteLine($"Smallest cohort was {cohortStudentCount.Min()}");
      Console.WriteLine($"Total students is {cohortStudentCount.Sum()}");

      IEnumerable<int> idealSizes = from count in cohortStudentCount
                                    where count < 27 && count > 19
                                    orderby count ascending
                                    select count;

      Console.WriteLine($"Average ideal size is {idealSizes.Average()}");

      // The @ symbol lets you create multi-line strings in C#
      Console.WriteLine($@"
        There were {idealSizes.Count()} ideally sized cohorts
        There have been {cohortStudentCount.Count()} total cohorts");


      // LINQ complex objects
      List<Shape> shapes = new List<Shape>()
        {
          new Shape() {NumberOfSides = 3, Height = 10.5, Width = 15.2 , Color = "Orange"},
          new Shape() {NumberOfSides = 4, Height = 15, Width = 6.5 , Color = "Red"},
          new Shape() {NumberOfSides = 1, Height = 12, Width = 12 , Color = "Blue"}
        };

      Shape foundRectangle = shapes.Find(shape => shape.NumberOfSides == 4);
      List<Shape> foundPolygons = shapes.Where(shape => shape.NumberOfSides > 1).ToList();

      double sumOfHeights = shapes.Select(shape => shape.Height).Sum();
      Console.WriteLine($"Sum of Heights: {sumOfHeights}");
    }
  }
}

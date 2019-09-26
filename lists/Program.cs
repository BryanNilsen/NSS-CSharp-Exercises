using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");
      foreach (string a in planetList)
        Console.WriteLine(a);

      List<string> otherplanets = new List<string>() { "Uranus", "Pluto" };
      planetList.AddRange(otherplanets);

      planetList.Insert(1, "Venus");
      planetList.Insert(2, "Earth");

      // get range takes two arguments, the index to start and the number of items
      List<string> rockyplanets = planetList.GetRange(0, 4);

      planetList.Remove("Pluto");

      foreach (string planet in planetList)
        Console.WriteLine($"New List: {planet}");

      foreach (string planet in rockyplanets)
        Console.WriteLine($"Rocky: {planet}");
    }
  }
}


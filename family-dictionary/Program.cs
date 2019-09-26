using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

      myFamily.Add("mother", new Dictionary<string, string>()
        {{"name", "Thelma"}, {"age", "67"}});

      myFamily.Add("sister", new Dictionary<string, string>()
        {{"name", "Louise"}, {"age", "22"}});

      myFamily.Add("brother", new Dictionary<string, string>()
        {{"name", "Johnny"}, {"age", "31"}});


      foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
      {
        string relation = familyMember.Key;
        string name = familyMember.Value["name"];
        string age = familyMember.Value["age"];

        Console.WriteLine($"{name} is my {relation} and is {age} years old.");
      }
    }
  }
}

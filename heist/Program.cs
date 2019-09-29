using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {
      // Print the message "Plan Your Heist!".
      Console.WriteLine("Plan Your Heist!");

      // Create a way to store several team members. Each team member will have a Name and a Skill Level. The Skill Level will be a number.
      List<Dictionary<string, int>> team = new List<Dictionary<string, int>>();
      Dictionary<string, int> newMember = new Dictionary<string, int>();


      // Prompt the user to enter a team member's name and save that name.
      Console.WriteLine("Enter Team Member's Name: ");
      string nameInput = Console.ReadLine();

      // Prompt the user to enter a team member's skill level
      Console.WriteLine("Enter Team Member's Skill Level: ");
      string skillInput = Console.ReadLine();
      int skill = Convert.ToInt32(skillInput);

      // save that skill level with the name.
      newMember.Add(nameInput, skill);

      team.Add(newMember);

      // Display the team member's information.
      foreach (Dictionary<string, int> item in team)
      {
        Console.WriteLine($"Team Member:");
        foreach (KeyValuePair<string, int> kvp in item)
        {
          Console.WriteLine($"NAME: {kvp.Key} - SKILL: {kvp.Value}");
        }
      }
    }
  }
}

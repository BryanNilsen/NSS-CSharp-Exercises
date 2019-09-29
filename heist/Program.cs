using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {

      bool isEnteringMember = true;
      // Print the message "Plan Your Heist!".
      Console.WriteLine("Plan Your Heist!");

      // Create a way to store several team members. Each team member will have a Name and a Skill Level. The Skill Level will be a number.
      List<Dictionary<string, int>> team = new List<Dictionary<string, int>>();

      while (isEnteringMember)
      {
        // Prompt the user to enter a team member's name and save that name.
        Console.WriteLine("Enter Team Member's Name: ");
        string nameInput = Console.ReadLine();

        // Stop collecting team members when a blank name is entered.
        if (nameInput == "")
        {
          break;
        }

        // Prompt the user to enter a team member's skill level
        Console.WriteLine("Enter Team Member's Skill Level: ");
        string skillInput = Console.ReadLine();
        if (skillInput == "")
        {
          skillInput = "0";
        }
        int skill = Convert.ToInt32(skillInput);

        // save that skill level with the name.
        Dictionary<string, int> newMember = new Dictionary<string, int>();
        newMember.Add(nameInput, skill);

        team.Add(newMember);

      }


      // Display a message containing the number of members of the team.
      Console.WriteLine($"There are {team.Count} team members:");

      // Display each team member's information.
      foreach (Dictionary<string, int> item in team)
      {
        foreach (KeyValuePair<string, int> kvp in item)
        {
          Console.WriteLine($"- NAME: {kvp.Key} - SKILL: {kvp.Value}");
        }
      }
    }
  }
}

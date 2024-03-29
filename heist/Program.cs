﻿using System;
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

      // Store a value for the bank's difficulty level.
      int bankDifficulty = 0;

      // At the beginning of the program, prompt the user to enter the difficulty level of the bank.
      while (bankDifficulty == 0)
      {
        Console.WriteLine("Enter Bank Difficulty: ");
        int bankDifficultyInput;

        // ensure input is an integer
        if (!int.TryParse(Console.ReadLine(), out bankDifficultyInput))
        {
          Console.Clear();
          Console.WriteLine("!! Please Enter a number greater than 0");
        }
        else
        {
          bankDifficulty = Convert.ToInt32(bankDifficultyInput);
        }
      }



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

      // Display each team member's information. (COMMENTED OUT PER INSTRUCTIONS)
      // foreach (Dictionary<string, int> item in team)
      // {
      //   foreach (KeyValuePair<string, int> kvp in item)
      //   {
      //     Console.WriteLine($"- NAME: {kvp.Key} - SKILL: {kvp.Value}");
      //   }
      // }

      // After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
      Console.WriteLine("Enter Number of Trial Runs: ");
      string trialRunsInput = Console.ReadLine();
      int trialRuns = Convert.ToInt32(trialRunsInput);


      // set initial number of successful heists
      int successfulHeists = 0;


      // Run the scenario multiple times.
      // Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck factor each time.
      for (int i = 0; i < trialRuns; i++)
      {

        // Create a random number between 0 and 20 for the heist's luck factor.
        Random random = new Random();
        int luckFactor = random.Next(0, 20);

        int teamSkillLevel = 0;

        // Sum the skill levels of the team. Save that number.
        foreach (Dictionary<string, int> item in team)
        {
          foreach (KeyValuePair<string, int> kvp in item)
          {
            teamSkillLevel += kvp.Value;
          }
        }

        // Add this number to the team's skill level before comparing it to the bank's difficulty level.
        // Before displaying the success or failure message, Display a report that shows.
        // The team's combined skill level
        // The luck factor
        // The team's skill level plus the luck factor.
        // The bank's difficulty.
        Console.WriteLine($"HEIST REPORT:");
        Console.WriteLine($"  - Team Combined Skill Level: {teamSkillLevel}");
        Console.WriteLine($"  - LuckFactor: {luckFactor}");
        Console.WriteLine($"  - Team Skill + Luck: {teamSkillLevel + luckFactor}");
        Console.WriteLine($"  - Bank Difficulty: {bankDifficulty}");


        // Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
        if (teamSkillLevel + luckFactor >= bankDifficulty)
        {
          Console.WriteLine($"The heist was Successful!");

          // increment successful heist count
          successfulHeists++;
        }
        else
        {
          Console.WriteLine($"The heist failed!");
        }
      }

      // At the end of the program, display a report showing the number of successful runs and the number of failed runs.
      Console.WriteLine($"TOTAL HEISTS: {trialRuns}");
      Console.WriteLine($"SUCCESSFUL HEISTS: {successfulHeists}");
      Console.WriteLine($"FAILED HEISTS: {trialRuns - successfulHeists}");
    }
  }
}


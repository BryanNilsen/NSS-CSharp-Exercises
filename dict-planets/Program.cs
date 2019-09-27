using System;
using System.Collections.Generic;

namespace planets
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };


      // Add some planet/probe combinations to the list
      List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();

      probeDestinations.Add(new KeyValuePair<string, string>("Messenger", "Mercury"));
      probeDestinations.Add(new KeyValuePair<string, string>("Mariner 10", "Mercury"));
      probeDestinations.Add(new KeyValuePair<string, string>("Viking 1", "Mars"));
      probeDestinations.Add(new KeyValuePair<string, string>("Mariner 3", "Mars"));
      probeDestinations.Add(new KeyValuePair<string, string>("Mariner 6", "Mars"));
      probeDestinations.Add(new KeyValuePair<string, string>("Mariner 7", "Mars"));
      probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Venus"));
      probeDestinations.Add(new KeyValuePair<string, string>("Mariner 2", "Venus"));
      probeDestinations.Add(new KeyValuePair<string, string>("Mariner 5", "Venus"));
      probeDestinations.Add(new KeyValuePair<string, string>("Mariner 10", "Venus"));
      probeDestinations.Add(new KeyValuePair<string, string>("Pioneer", "Venus"));
      probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Jupiter"));
      probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Jupiter"));
      probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 10", "Jupiter"));
      probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 11", "Jupiter"));
      probeDestinations.Add(new KeyValuePair<string, string>("Ulysses", "Jupiter"));
      probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Saturn"));
      probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Saturn"));
      probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 11", "Saturn"));
      probeDestinations.Add(new KeyValuePair<string, string>("Cassini", "Saturn"));
      probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Neptune"));
      probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Uranus"));

      // Iterate over planetList, and inside that loop, iterate over the list of key-value pairs. Write to the console, for each planet, which probes have visited it.
      foreach (string planet in planetList)
      {
        List<string> matches = new List<string>();

        foreach (KeyValuePair<string, string> pair in probeDestinations)
        {
          if (pair.Value == planet)
          {
            matches.Add(pair.Key);
          }
        }

        string planetMatches = String.Join(", ", matches);
        Console.WriteLine($"{planet}: {planetMatches}");
      }
    }
  }
}



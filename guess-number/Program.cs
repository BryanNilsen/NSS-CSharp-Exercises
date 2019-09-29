using System;
using System.Collections.Generic;

namespace guess_number
{
  class Program
  {
    static void Main(string[] args)
    {
      string guess;
      Console.Write("Guess a Number: ");
      guess = Console.ReadLine();

      // convert string to integer
      int num = Convert.ToInt32(guess);
      Console.WriteLine("Your guess: {0}", num);
    }
  }
}

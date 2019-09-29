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

      // create a secret number
      int secret = 42;

      // convert string to integer
      int num = Convert.ToInt32(guess);

      if (num == secret)
      {
        Console.WriteLine("You guessed correctly!");
      }
      else
      {
        Console.WriteLine("Sorry, you guessed incorrectly.");
      }
    }
  }
}

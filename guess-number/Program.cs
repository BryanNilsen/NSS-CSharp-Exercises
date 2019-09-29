using System;
using System.Collections.Generic;

namespace guess_number
{
  class Program
  {
    static void Main(string[] args)
    {
      // set guess counter
      int guessCount = 0;

      while (guessCount < 5)
      {
        string guess;
        Console.Write("Guess a Number: ");
        guess = Console.ReadLine();

        // create a secret number
        int secret = 42;

        // convert string to integer
        int num = Convert.ToInt32(guess);


        // evaluate match
        if (num == secret)
        {
          Console.WriteLine("You guessed correctly!");
          guessCount++;
        }
        else
        {
          Console.WriteLine("Sorry, you guessed incorrectly.");
          guessCount++;
        }
      }
    }
  }
}

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

      // create a random secret number
      Random random = new Random();
      int secret = random.Next(0, 100);


      while (guessCount < 4)
      {
        string guess;
        Console.Write($"Guesses left({4 - guessCount}) - Guess a number between 1 - 100: ");
        guess = Console.ReadLine();

        // convert string to integer
        int num = Convert.ToInt32(guess);


        // evaluate match
        if (num == secret)
        {
          Console.WriteLine("You guessed correctly!");
          guessCount = 4;
        }
        else
        {
          if (num >= secret)
          {
            Console.WriteLine("Sorry, that's too high.");
          }
          else
          {
            Console.WriteLine("Sorry, that's too low.");
          }
          guessCount++;
        }
      }
      // display secret number when game over
      if (guessCount == 4)
      {
        Console.WriteLine($"The secret number was {secret}");
      }
    }
  }
}

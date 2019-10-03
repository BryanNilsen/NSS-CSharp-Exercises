using System;
using System.Collections.Generic;

namespace guess_number
{
  class Program
  {
    static void Main(string[] args)
    {

      // set initial difficulty to 0 guesses
      int difficulty = 0;

      // allow user to choose difficulty
      string difficultyInput;

      Console.Write($"Choose Difficulty -- Easy(1), Medium(2), Hard(3) : ");
      difficultyInput = Console.ReadLine();

      // set number of guesses based on user difficulty input
      if (difficultyInput == "1")
      {
        difficulty = 8;
      }
      if (difficultyInput == "2")
      {
        difficulty = 6;
      }
      if (difficultyInput == "3")
      {
        difficulty = 4;
      }


      // set guess counter
      int guessCount = 0;

      // create a random secret number
      Random random = new Random();
      int secret = random.Next(1, 100);

      // using for loop
      for (int i = 0; i < difficulty; i++)
      {
        string guess;
        Console.WriteLine($"Guesses left({difficulty - i})");
        Console.WriteLine($"Guess a number between 1 - 100: ");
        guess = Console.ReadLine();
        int num = Convert.ToInt32(guess);

        if (num == secret)
        {
          Console.WriteLine("You guessed correctly!");
          break;
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
        }
      }

      // using while loop
      /*
            while (guessCount < difficulty)
            {
              string guess;
              Console.Write($"Guesses left({difficulty - guessCount}) - Guess a number between 1 - 100: ");
              guess = Console.ReadLine();

              // convert string to integer
              int num = Convert.ToInt32(guess);


              // evaluate match
              if (num == secret)
              {
                Console.WriteLine("You guessed correctly!");
                guessCount = difficulty;
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

        */

      // display secret number when game over
      if (guessCount == difficulty)
      {
        Console.WriteLine($"The secret number was {secret}");
      }
    }
  }
}

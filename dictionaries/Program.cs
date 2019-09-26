using System;
using System.Collections.Generic;

namespace dictionaries
{
  class Program
  {
    static void Main(string[] args)
    {
      // PRACTICE - DICTIONARY OF WORDS
      // Create a dictionary with key value pairs to represent words (key) and its definition (value)
      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
      { "hospital", "a big building with patients, but that's not important right now"},
      { "cockpit", "the little room at the front of the plane where the pilots sit, but that's not important right now"}
      };

      // Add several more words and their definitions
      wordsAndDefinitions.Add("headquarters", "a big building where generals meet but that’s not important right now");

      // Use square brackets to get the definition of two of the words and then output them to the console
      Console.WriteLine($"{wordsAndDefinitions["hospital"]}");
      Console.WriteLine($"{wordsAndDefinitions["cockpit"]}");

      /*
          Below, loop over the wordsAndDefinitions dictionary to get the following output:
              The definition of (WORD) is (DEFINITION)
      */
      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
        Console.WriteLine($"The definition of {word.Key} is {word.Value}");
      }

      // PRACTICE - LIST OF DICTIONARIES
      // Make a new list
      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

      /*
          You want to track the following about each word:
              word, definition, part of speech, example sentence

          Example of one dictionary in the list:
          {
              "word": "excited",
              "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
              "part of speech": "adjective",
              "example sentence": "I am excited to learn C#!"
          }
      */

      // Create dictionary to represent a few words
      Dictionary<string, string> excitedWord = new Dictionary<string, string>();

      // Add each of the 4 bits of data about the word to the Dictionary
      excitedWord.Add("word", "excited");
      excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
      excitedWord.Add("part of speech", "adjective");
      excitedWord.Add("example sentence", "I am excited to learn C#");

      // Add Dictionary to your `dictionaryOfWords` list
      dictionaryOfWords.Add(excitedWord);

      // create another Dictionary and add that to the list
      Dictionary<string, string> happyWord = new Dictionary<string, string>(){
        {"word", "happy"},
        {"definition", "to be happy"},
        {"part of speech", "adjective"},
        {"example sentence", "I am happy"}
      };

      dictionaryOfWords.Add(happyWord);
      /*
          Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

          Example output for one word in the list of dictionaries:
              word: excited
              definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
              part of speech: adjective
              example sentence: I am excited to learn C#!
      */

      // Iterate the List of Dictionaries
      foreach (Dictionary<string, string> entry in dictionaryOfWords)
      {
        // Iterate the KeyValuePairs of the Dictionary
        foreach (KeyValuePair<string, string> attribute in entry)
        {
          Console.WriteLine($"{attribute.Key}: {attribute.Value}");
        }
      }
    }
  }
}

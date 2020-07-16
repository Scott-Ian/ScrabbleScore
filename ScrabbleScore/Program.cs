using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("");
      Console.WriteLine("Welcome to the Scrabble word value calculator!");
      Console.WriteLine("Enter a word and I will tell you how many points it is worth: ");
      Start();
    }
    public static void Start()
    {
      Console.WriteLine("Which word would you like to know the value of?");
      string inputWord = Console.ReadLine();
      int wordResult = ScoreCounter.Score(inputWord.ToUpper());
      Console.WriteLine("The word " + inputWord + " is worth: " + wordResult + " points!");
      Start();
    }

    public static string GetInput()
    {
      Console.WriteLine("Which word would you like to know the value of?");
      string inputWord = Console.ReadLine();
      letterChecker();
      if (letterChecker == true)
      {
        int wordResult = ScoreCounter.Score(inputWord.ToUpper());
        Console.WriteLine("The word " + inputWord + " is worth: " + wordResult + " points!");
      }
      else
      {
        Console.WriteLine("Please make sure your word contains no spaces, numbers or special characters")
        GetInput();
      }
      }

    public static string letterChecker()
    { foreach(char letter in inputWord)
      {
        if (char.IsLetter(letter) != true)
        {
          return false;
        }
        else
        {
          return true;
        }
        }
      
    }
  }
}
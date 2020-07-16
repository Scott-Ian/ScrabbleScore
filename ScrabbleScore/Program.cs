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
      GetInput();
    }

    public static void GetInput()
    {
      Console.WriteLine("Which word would you like to know the value of?");
      string inputWord = Console.ReadLine();
      if (letterChecker(inputWord) == true)
      {
        int wordResult = ScoreCounter.Score(inputWord.ToUpper());
        Console.WriteLine("The word " + inputWord + " is worth: " + wordResult + " points!");
        GetInput();
      }
      else
      {
        Console.WriteLine("Please make sure your word contains no spaces, numbers or special characters");
        GetInput();
      }
    }

    public static bool letterChecker(string inputWord)
    { 
      foreach(char letter in inputWord)
      {
        if (char.IsLetter(letter) != true)
        {
          return false;
        }
      }
        return true;
    }
  }
}
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine();
      Console.WriteLine("WELCOME TO THE WORD COUNTER");
      PartOne();
    }

    public static void PartOne()
    {
      Console.WriteLine();
      Console.WriteLine("ENTER A SENTENCE OR PARAGRAPH:");
      string userSentenceInput = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("ENTER THE WORD YOU WOULD LIKE TO SEARCH FOR");
      string userWordInput = Console.ReadLine();
      Counter newCounter = new Counter(userWordInput, userSentenceInput);
      bool emptyInput = newCounter.EmptyInput();
      if (emptyInput == true)
      {
      Console.WriteLine("Please Re-Enter Your Selection");
      PartOne();
      }
      else {}
      string[] userInputArray = newCounter.SplitSentence();
      newCounter.CountWords(userInputArray);
      Console.WriteLine();
      Console.WriteLine("SENTENCE: " + userSentenceInput);
      Console.WriteLine("WORD: " + userWordInput);
      Console.WriteLine("WORD FREQUENCY: " + newCounter.WordScore);
      PartTwo();
    }
      
    public static void PartTwo()
    {
      Console.WriteLine("");
      Console.WriteLine("Would you like to search another sentence? [Y OR N]");
      string yesOrNo = Console.ReadLine();
      if (yesOrNo == "Y" || yesOrNo == "y")
      PartOne();
      else if (yesOrNo == "N" || yesOrNo == "n")
      Exit();
      else
      PartTwo();
    }
    public static void Exit()
    {
      Console.WriteLine("");
      Console.WriteLine("GOODBYE!");
    }
  }
}
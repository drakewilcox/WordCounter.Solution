using System; 
using System.Collections.Generic; 

namespace WordCounter.Models
{
  public class Counter
  {
    public string InputWord { get; set; }
    public string InputSentence { get; set; }
    public int WordScore { get; set; }
    

    public Counter (string inputWord, string inputSentence)
    {
      InputWord = inputWord.ToLower();
      InputSentence = inputSentence.ToLower(); 
      WordScore = 0; 
      
    }
    public bool EmptyInput ()
    {
      if (InputWord == "" || InputSentence == "")
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

    public string[] SplitSentence()
    {
      string [] wordArray = InputSentence.Split(" ");
      return wordArray;
    }



  }
}

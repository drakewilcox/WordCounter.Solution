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
      InputWord = inputWord;
      InputSentence = inputSentence; 
      WordScore = 0; 
    }
    public string EmptyInput ()
    {
      if (InputWord == "" || InputSentence == "")
      {
        return "RE-ENTER YOUR SELECTION";
      }
      else 
      {
        return "error";
      }
    }
  }
}

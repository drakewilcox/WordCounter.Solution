using System; 

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
    }
    
    public bool EmptyInput()
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
      char[] delimiterChars = {' ', ',', '.', ':', '!','\t'};
      string [] wordArray = InputSentence.Split(delimiterChars);
      
      return wordArray;
    }

    public void CountWords(string[] wordArray)
    {
      foreach (var word in wordArray)
      {
        if(word == InputWord)
        {
          WordScore += 1;
        }
        else 
        {
          
        }
      }
    }
  }
}

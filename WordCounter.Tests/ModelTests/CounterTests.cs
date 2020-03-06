using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void EmptyInput_IfUserInputAndSentenceAreEmpty_String()
    {
      Counter newCounter = new Counter("", "");

      bool result = newCounter.EmptyInput();

      Assert.AreEqual(result, true);
    }

    [TestMethod]
    public void SplitSentence_IfMethodReturnsAnArray_StringArray()
    {
      Counter newCounter = new Counter("Mystery", "Its All A Mystery");

      string[] result = newCounter.SplitSentence();
      string[] wordTestArray = {"its", "all", "a", "mystery"};
      CollectionAssert.AreEqual(result, wordTestArray);
    }
    [TestMethod]
    public void CountWords_MethodAddsToWordScore_Int()
    {
      Counter newCounter = new Counter("Mystery", "Its All A Mystery");

      string[] wordTestArray = newCounter.SplitSentence();
      newCounter.CountWords(wordTestArray);
      int result = newCounter.WordScore;

      Assert.AreEqual(result, 1);
    }

  }
}
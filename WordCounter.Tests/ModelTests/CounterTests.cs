using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void CounterConstructor_CreateInstanceOfCounter_Counter()
    {
      Counter newCounter = new Counter("Mystery", "Its All A Mystery");

      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }
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
      Counter newCounter = new Counter("Mystery", "It's All A Mystery");

      string[] wordTestArray = newCounter.SplitSentence();
      newCounter.CountWords(wordTestArray);
      int result = newCounter.WordScore;

      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void CountWords_DoesNotIncludeWordsThatContainInputWord_Int()
    {
      Counter newCounter = new Counter("Bat", "Batman does not look like a bat, the bat looks like a bat.");

      string[] wordTestArray = newCounter.SplitSentence();
      newCounter.CountWords(wordTestArray);
      int result = newCounter.WordScore;

      Assert.AreEqual(result, 3);
    }
    
    [TestMethod]
    public void CountWords_MethodAccountsForLowerCaseWords_Int()
    {
      Counter newCounter = new Counter("mystery", "OH, IT'S ALL JUST A MYSTERY!"); 
      string[] wordTestArray = newCounter.SplitSentence();
      newCounter.CountWords(wordTestArray);
      int result = newCounter.WordScore; 

      Assert.AreEqual(result, 1);
    }
  }
}
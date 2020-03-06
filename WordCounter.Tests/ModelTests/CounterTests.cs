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

      string result = newCounter.EmptyInput();

      Assert.AreEqual(result, "RE-ENTER YOUR SELECTION");
    }
  }
}
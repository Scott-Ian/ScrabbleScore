using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.TestTools
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void ScoreCounterConstructor_CreatesInstanceOfScoreCounter_ScoreCounter()
    {
      ScoreCounter counter = new ScoreCounter();
      Assert.AreEqual(typeof(ScoreCounter), counter.GetType());
    }
  }
}
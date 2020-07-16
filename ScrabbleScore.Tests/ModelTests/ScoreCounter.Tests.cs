using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System.Collections.Generic;
using System;

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

    [TestMethod]
    public void Score_ReturnsInt_Int()
    {
      //Arrange
      string testString = "Hello";

      //Act
      int testScore = ScoreCounter.Score(testString);

      //Assert
      Assert.AreEqual(typeof(int), ScoreCounter.Score(testString).GetType());
    }
  }
}
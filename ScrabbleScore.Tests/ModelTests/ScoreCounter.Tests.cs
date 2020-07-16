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
      string testString = "H";

      //Act
      int testScore = ScoreCounter.Score(testString);

      //Assert
      Assert.AreEqual(typeof(int), testScore.GetType());
    }

    [TestMethod]
    public void Score_ReturnsDictionaryValue_Int()
    {
      // Arrange
      string oneLetter = "A";

      // Act
      int letterTest = ScoreCounter.Score(oneLetter);

      // Assert
      Assert.AreEqual(1, letterTest);
    }

    [TestMethod]
    public void Score_ReturnsTotalWordScore_Int()
    {
      //Arrange
      string testWord = "HELLO";

      //Act
      int testWordScore = ScoreCounter.Score(testWord);

      //Assert
      Assert.AreEqual(8, testWordScore);
    }
  }
}
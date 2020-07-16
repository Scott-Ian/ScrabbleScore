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
    public void DictionaryConstructor_CreatesInstanceOfLetterDictionary_LetterDictionary()
    {
      Assert.AreEqual(typeof(Dictionary <string, int>), ScoreCounter.charScoreDictionary.GetType());
    }
  }
}
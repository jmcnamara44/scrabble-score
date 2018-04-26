using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest : IDisposable
  {
    public void Dispose()
    {

    }
    [TestMethod]
    public void ReturnWord_ReturnsWord_Word()
    {
      string testWord1 = "abc";
      Letter newWord = new Letter(testWord1);
      Assert.AreEqual(testWord1, newWord.GetWord());
    }
  }
}

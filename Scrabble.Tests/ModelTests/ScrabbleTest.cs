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
      Letter.ClearAll();
    }
    [TestMethod]
    public void GetWord_ReturnsWord_Word()
    {
      string testWord1 = "abc";
      Letter newWord = new Letter(testWord1);
      Assert.AreEqual(testWord1, newWord.GetWord());
    }
    [TestMethod]
    public void WordToList_ReturnsWordInAList_WordInAList()
    {
      Letter testWord1 = new Letter("A");
      Letter testWord2 = new Letter("B");
      Letter testWord3 = new Letter("C");
      List<Letter> testList1 = new List<Letter> {testWord1, testWord2, testWord3};
      Letter newWord = new Letter("abc");
      Letter.WordToList(newWord);
      List<Letter> testList2 = Letter.GetAll();
      Assert.AreEqual(testList1[0].GetWord(), testList2[0].GetWord());
      Assert.AreEqual(testList1[1].GetWord(), testList2[1].GetWord());
      Assert.AreEqual(testList1[2].GetWord(), testList2[2].GetWord());
      Assert.AreEqual(testList1.Count, testList2.Count);
    }
    [TestMethod]
    public void WordToList_ComparesWordToADictionary_True()
    {
      Letter newWord1 = new Letter("ZAQ");
      Letter.WordToList(newWord1);
      int score = Letter.WordScore();
      Assert.AreEqual(21, score);
    }
    [TestMethod]
    public void WordScore_ComparesAnyCaseWordToADictionary_True()
    {
      Letter newWord1 = new Letter("azq");
      Letter.WordToList(newWord1);
      int score = Letter.WordScore();
      Assert.AreEqual(21, score);
    }
  }
}

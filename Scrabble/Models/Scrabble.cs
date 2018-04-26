using System.Collections.Generic;
using System.IO;
using System;

namespace Scrabble.Models
{
    public class Letter
    {
        private string _word;
        private static int _wordScore = 0;

        private static Dictionary<string, int> scores = new Dictionary<string, int> { {"A", 1}, {"B", 3}, {"C", 3}, {"D", 2}, {"E", 1}, {"F", 4}, {"G", 2}, {"H", 4}, {"I", 1}, {"J", 8}, {"K", 5}, {"L", 1}, {"M", 3}, {"N", 1}, {"O", 1}, {"P", 3}, {"Q", 10}, {"R", 1}, {"S", 1}, {"T", 1}, {"U", 1}, {"V", 4}, {"W", 4}, {"X", 8}, {"Y", 4}, {"Z", 10} };

        private static List<Letter> _letters = new List<Letter> {};

        public Letter(string word)
        {
          _word = word;
        }

        public string GetWord()
        {
          return _word;
        }

        public static void WordToList(Letter word)
        {
          char[] wordArray = word.GetWord().ToCharArray();
          for (int x = 0; x<wordArray.Length; x++)
          {
            Letter testStringx = new Letter(String.Join("", wordArray[x]));
            testStringx.Save();
          }
        }
        public static int GetScore()
        {
          return _wordScore;
        }

        public static void WordScore()
        {
          for(var i = 0; i<_letters.Count; i++)
          {
            if (scores.ContainsKey(_letters[i].GetWord()))
            {
              _wordScore += scores[_letters[i].GetWord()];
            }

          }
        }
        public void Save()
        {
          _letters.Add(this);
        }

        public static List<Letter> GetAll()
        {
          return _letters;
        }
    }
}

using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLogic.Services
{
    //Service, that works with text. Works with cyrillic and latin
    public class TextService: ITextService
    {
        private char[] charsToNotInclude = { ' ' };

        //return only one most popular char
        //chars that are upper case and lower case are different
        public string GetTheMostPopularChar(string textToAnalize)
        {
            var mostPopularChar = textToAnalize
                .Where(x => !charsToNotInclude.Contains(x))
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .First().Key;

            return mostPopularChar.ToString();
        }

        //return only one least popular char
        //chars that are upper case and lower case are different
        public string GetTheLeastPopularChar(string textToAnalize)
        {
            var leastPopularChar = textToAnalize
                .Where(x => !charsToNotInclude.Contains(x))
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Last().Key;

            return leastPopularChar.ToString();
        }

        public int GetCountOfUpperCaseChars(string textToAnalyze)
        {
            var count = textToAnalyze.Count(c => char.IsUpper(c));
            return count;
        }

        public int GetCountOfSentences(string textToAnalyze)
        {
            var sentences = Regex.Split(textToAnalyze, @"(?<=[\.!\?])\s+");
            return sentences.Count();
        }
    }
}

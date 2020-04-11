using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface ITextService
    {
        string GetTheMostPopularChar(string textToAnalize);

        string GetTheLeastPopularChar(string textToAnalize);

        int GetCountOfUpperCaseChars(string textToAnalyze);

        int GetCountOfSentences(string textToAnalyze);
    }
}

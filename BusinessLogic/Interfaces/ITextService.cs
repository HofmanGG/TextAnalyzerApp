using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface ITextService
    {
        //returns only one most popular char
        //chars that are upper case and lower case are different
        string GetTheMostPopularChar(string textToAnalize);

        //returns only one least popular char
        //chars that are upper case and lower case are different
        string GetTheLeastPopularChar(string textToAnalize);

        int GetCountOfUpperCaseChars(string textToAnalyze);

        int GetCountOfSentences(string textToAnalyze);
    }
}

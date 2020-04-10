using BusinessLogic.DTOs;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public interface ITextAnalyzerService
    {
        MetricsDto GetMetricsOfText(string textToAnalize);

        string GetTheMostPopularChar(string textToAnalize);

        string GetTheLeastPopularChar(string textToAnalize);

        int GetCountOfUpperCaseChars(string textToAnalyze);

        int GetCountOfSentences(string textToAnalyze);
    }
}
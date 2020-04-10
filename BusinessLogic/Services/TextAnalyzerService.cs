using BusinessLogic.DTOs;
using System.Linq;
using System.Text.RegularExpressions;

namespace BusinessLogic.Services
{
    //Service, which works with metrics. Works with cyrillic and latin
    /*So, if you want to add a new metric, just create a private method and describe the logic in it,
    and then just set the property of metricsDto to the result of the method*/
    /*ещё добавлю, что возможно в задании имелось ввиду что надо создать на фронте набор метрик,
    и юзер сам ставил галочки какие метрики ему нужны, и если так то можно просто скопипастить GetMetrixOfText и просто передавать туда
    bool для каждой метрики. Но возможно не это имелось ввиду в задании поэтому я сделал просто так. Ещё добавлю, что у меня
    есть проект на Github https://github.com/HofmanGG/RepairService сайт ремонта техники, можете также посмотреть и его.*/
    /*и ещё, само собой я мог написать бомбезные юнит тесты xUnit/NUnit + Moq + AutoFixture + FluentAsssetions, сделать лучше фронт,
    сделать больше метрик, но сколько надо делать метрик и их сложность в задании не указано, поэтому я просто сделал то, что от меня хотели в задании*/
    public class TextAnalyzerService: ITextAnalyzerService
    {
        private char[] charsToNotInclude = { ' ' };
        
        public MetricsDto GetMetricsOfText(string textToAnalize)
        {
            var metrics = new MetricsDto();

            metrics.MostPopularChar = GetTheMostPopularChar(textToAnalize);
            metrics.LeastPopularChar = GetTheLeastPopularChar(textToAnalize);
            metrics.CountOfUpperCaseChars = GetCountOfUpperCaseChars(textToAnalize);
            metrics.CountOfSentences = GetCountOfSentences(textToAnalize);

            return metrics;
        }

        //возможно в будущем метрики будут вызываться по отдельности, поэтому я сделал их public
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

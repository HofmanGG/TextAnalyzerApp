using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Services
{
    //Service, which works with metrics
    /*ещё добавлю, что возможно в задании имелось ввиду что надо создать на фронте набор метрик,
    и юзер сам ставил галочки какие метрики ему нужны, и если так то можно просто скопипастить GetMetrixOfText и просто передавать туда
    bool для каждой метрики. Но возможно не это имелось ввиду в задании поэтому я сделал просто так. Ещё добавлю, что у меня
    есть проект на Github https://github.com/HofmanGG/RepairService сайт ремонта техники, можете также посмотреть и его.*/
    /*и ещё, само собой я мог написать бомбезные юнит тесты xUnit/NUnit + Moq + AutoFixture + FluentAsssetions, сделать лучше фронт,
    сделать больше метрик, но сколько надо делать метрик и их сложность в задании не указано, поэтому я просто сделал то, что от меня хотели в задании.*/
    public class TextMetricsService : ITextMetricsService
    {
        private readonly ITextService _textService;
        public TextMetricsService(ITextService textService)
        {
            _textService = textService;
        }            

        public TextMetricsDto GetAllMetricsOfText(string textToAnalize)
        {
            var metrics = new TextMetricsDto();

            metrics.MostPopularChar = _textService.GetTheMostPopularChar(textToAnalize);
            metrics.LeastPopularChar = _textService.GetTheLeastPopularChar(textToAnalize);
            metrics.CountOfUpperCaseChars = _textService.GetCountOfUpperCaseChars(textToAnalize);
            metrics.CountOfSentences = _textService.GetCountOfSentences(textToAnalize);

            return metrics;
        }
    }
}

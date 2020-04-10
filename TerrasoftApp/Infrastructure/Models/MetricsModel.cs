namespace TextAnalyzerApp.Infrastructure.Models
{
    public class MetricsModel
    {
        public string MostPopularChar { get; set; }
        public string LeastPopularChar { get; set; }
        public int CountOfUpperCaseChars { get; set; }
        public int CountOfSentences { get; set; }
    }
}

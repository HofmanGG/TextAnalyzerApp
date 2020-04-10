using BusinessLogic.DTOs;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public interface ITextAnalyzerService
    {
        MetricsDto GetMetricsOfText(string textToAnalize);
    }
}
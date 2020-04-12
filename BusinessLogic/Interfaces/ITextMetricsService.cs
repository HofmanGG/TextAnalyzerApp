using BusinessLogic.DTOs;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public interface ITextMetricsService
    {
        TextMetricsDto GetAllMetricsOfText(string textToAnalize);
    }
}
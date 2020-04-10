using BusinessLogic.DTOs;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
    public interface IMetricsService
    {
        MetricsDto GetAllMetricsOfText(string textToAnalize);
    }
}
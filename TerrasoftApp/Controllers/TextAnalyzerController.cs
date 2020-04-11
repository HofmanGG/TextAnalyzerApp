using AutoMapper;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using TextAnalyzerApp.Infrastructure.Models;

namespace TextAnalyzerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class TextAnalyzerController : ControllerBase
    {
        private readonly IMetricsService _metricsService;
        private readonly IMapper _mapper;

        public TextAnalyzerController(IMetricsService metricsService, IMapper mapper)
        {
            _metricsService = metricsService;
            _mapper = mapper;
        }

        //because the input of the user can be long, we shouldnot use Get, so i use Post
        [HttpPost]
        public ActionResult<MetricsModel> GetAllMetrics(TextToAnalyzeModel textModel)
        {
            var metricsDto = _metricsService.GetAllMetricsOfText(textModel.TextToAnalyze);
            var metricsModel = _mapper.Map<MetricsModel>(metricsDto);
            return Ok(metricsModel);
        }
    }
}

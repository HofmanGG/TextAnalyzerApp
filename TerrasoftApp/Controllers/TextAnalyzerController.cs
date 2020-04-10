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
        private readonly ITextAnalyzerService _textAnalyzerService;
        private readonly IMapper _mapper;

        public TextAnalyzerController(ITextAnalyzerService textAnalyzerService, IMapper mapper)
        {
            _textAnalyzerService = textAnalyzerService;
            _mapper = mapper;
        }

        //because the input of the user can be long, we shouldnot use Get, so i use Post
        [HttpPost]
        public ActionResult<MetricsModel> GetMetrics(TextToAnalyzeModel textModel)
        {
            var metricsDto = _textAnalyzerService.GetMetricsOfText(textModel.TextToAnalyze);
            var metricsModel = _mapper.Map<MetricsModel>(metricsDto);
            return Ok(metricsModel);
        }
    }
}

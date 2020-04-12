using AutoMapper;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using TextAnalyzerApp.Infrastructure.Models;

namespace TextAnalyzerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class TextMetricsController : ControllerBase
    {
        private readonly ITextMetricsService _textMetricsService;
        private readonly IMapper _mapper;

        public TextMetricsController(ITextMetricsService textMetricsService, IMapper mapper)
        {
            _textMetricsService = textMetricsService;
            _mapper = mapper;
        }

        //because the input of the user can be long, we shouldnot use Get, so i use Post
        [HttpPost]
        public ActionResult<TextMetricsModel> GetAllMetrics(TextToAnalyzeModel textModel)
        {
            var metricsDto = _textMetricsService.GetAllMetricsOfText(textModel.TextToAnalyze);
            var metricsModel = _mapper.Map<TextMetricsModel>(metricsDto);
            return Ok(metricsModel);
        }
    }
}

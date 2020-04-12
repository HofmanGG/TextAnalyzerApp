using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.DTOs
{
    public class TextMetricsDto
    {
        public string MostPopularChar { get; set; }
        public string LeastPopularChar { get; set; }

        public int CountOfUpperCaseChars { get; set; }
        public int CountOfSentences { get; set; }
    }
}

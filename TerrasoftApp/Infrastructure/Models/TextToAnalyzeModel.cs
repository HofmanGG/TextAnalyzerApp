namespace TextAnalyzerApp.Infrastructure.Models
{
    /*i use this model because so you can easily create validation attibute for your models,
     so you dont need to perform validation manually in every method, you can just write validation in
     a separate file*/
    public class TextToAnalyzeModel
    {
        public string TextToAnalyze { get; set; }
    }
}

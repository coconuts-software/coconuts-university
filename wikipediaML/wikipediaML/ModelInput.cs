using Microsoft.ML.Data;

namespace wikipediaML
{
    public class ModelInput
    {
        [ColumnName("Sentiment"), LoadColumn(0)]
        public bool Sentiment { get; set; }

        [ColumnName("SentimentText"), LoadColumn(1)]
        public string SentimentText { get; set; }

    }
}
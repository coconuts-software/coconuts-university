using System;
using System.IO;
using Microsoft.ML;

namespace wikipediaML
{
    class Program
    {
        private static readonly string BaseDatasetsRelativePath = @"../../../Data";
        private static readonly string DataRelativePath = $"{BaseDatasetsRelativePath}/wikipedia-data.tsv";

        private static readonly string DataPath = GetAbsolutePath(DataRelativePath);

        static void Main(string[] args)
        {
            // crear un ML context
            MLContext mlContext = new MLContext(seed: 1);

            // cargar datos
            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                path: DataPath,
                hasHeader: true,
                separatorChar: '\t',
                allowQuoting: true,
                allowSparse: false);

            // crear un pipeline para extraer las features y agregar el algoritmo
            IEstimator<ITransformer> trainingPipeline = mlContext.Transforms.Text.FeaturizeText(outputColumnName: "Features", inputColumnName: nameof(ModelInput.SentimentText))
                .Append(mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: "Sentiment", featureColumnName: "Features"));

            // entrenar el modelo
            ITransformer model = trainingPipeline.Fit(trainingDataView);

            // evaluar el modelo
            //var metrics = mlContext.BinaryClassification.CrossValidateNonCalibrated(trainingDataView, trainingPipeline, numberOfFolds: 5, labelColumnName: "Sentiment");

            // probar el modelo
            // creamos un motor de predicciones basado en el modelo
            PredictionEngine<ModelInput, ModelOutput> predictionFunction = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);

            // creamos una frase para probar
            ModelInput frasePrueba = new ModelInput
            {
                SentimentText = "You are a bad person"
            };

            // le decimos al motor que genere una predicción
            var resultPrediction = predictionFunction.Predict(frasePrueba);
            Console.WriteLine("¿Es toxico? = " + resultPrediction.Prediction);

            frasePrueba.SentimentText = "Nice comment";
            var resultPrediction2 = predictionFunction.Predict(frasePrueba);
            Console.WriteLine("¿Es toxico? = " + resultPrediction2.Prediction);
        }

        public static string GetAbsolutePath(string relativePath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(Program).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;
        }
    }
}

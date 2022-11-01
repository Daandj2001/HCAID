using DiabetesPrediction.Models;

namespace DiabetesPrediction.Api
{
    public interface IWebAPIHelper
    {
        public Task<Prediction> PredictionGet(PredictionModel predictionModel);
    };
}

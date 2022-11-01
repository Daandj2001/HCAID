using DiabetesPrediction.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace DiabetesPrediction.Api
{
    public class WebApiHelper : IWebAPIHelper
    {
        private HttpClient _httpClient;
       

        public WebApiHelper()
        {

            _httpClient = new HttpClient();
            _httpClient.BaseAddress =
                new Uri("http://localhost:5000/api"); /// meshien nog /api achter de uri
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Prediction> PredictionGet(PredictionModel predictionModel)
        {
            //http://206.189.8.200:4999/api
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("http://localhost:5000/api", predictionModel);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Prediction prediction = JsonConvert.DeserializeObject<Prediction>(result);
                //double prediction = JsonConvert.DeserializeAnonymousType<>(result);
                return prediction;
            }
            else
            {
                throw new Exception();
            }

        }
    }
}

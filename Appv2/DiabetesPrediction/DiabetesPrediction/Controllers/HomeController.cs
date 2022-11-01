using DiabetesPrediction.Api;
using DiabetesPrediction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace DiabetesPrediction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebAPIHelper _webApiHelper;

        public HomeController(ILogger<HomeController> logger, IWebAPIHelper webApiHelper)
        {
            _logger = logger;
            _webApiHelper = webApiHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PredictForm()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PredictForm(PredictViewModel predictViewModel)
        {
            if (ModelState.IsValid)
            {
                float HeightInM = (float)predictViewModel.Height / 100;
                var BMI = predictViewModel.Weight / Math.Pow(HeightInM, 2);
                
                PredictionModel predictionModel = new PredictionModel()
                {
                    BMI = BMI,
                    PhysHlth = predictViewModel.PhysHlth,
                    
                   
                };
                if (predictViewModel.DiffWalk == true)
                {
                    predictionModel.DiffWalk = 1;
                }
                else { predictionModel.DiffWalk = 0; }
                if ( predictViewModel.Stroke == true)
                {
                    predictionModel.Stroke = 1;
                }
                else
                {
                    predictionModel.Stroke = 0;
                }
                if(predictViewModel.HeartDiseaseorAttack == true)
                {
                    predictionModel.HeartDiseaseorAttack = 1;
                }
                else
                {
                    predictionModel.HeartDiseaseorAttack = 0;
                }
                if (predictViewModel.PhysActivity == true)
                {
                    predictionModel.PhysActivity = 1;
                }
                else
                {
                    predictionModel.PhysActivity = 0;
                }

                if(predictViewModel.genHlth == 1)
                {
                    predictionModel.genHlth_1 = 1;
                }else if (predictViewModel.genHlth == 2)
                {
                    predictionModel.genHlth_2 = 1;
                }
                else if (predictViewModel.genHlth == 3)
                {
                    predictionModel.genHlth_3 = 1;
                }
                else if (predictViewModel.genHlth == 4)
                {
                    predictionModel.genHlth_4 = 1;
                }
                else if (predictViewModel.genHlth == 5)
                {
                    predictionModel.genHlth_5 = 1;
                }

                if (predictViewModel.Age >= 18 && predictViewModel.Age <= 24)
                {
                    predictionModel.Age_1 = 1;
                }
                else if (predictViewModel.Age >= 25 && predictViewModel.Age <= 29)
                {
                    predictionModel.Age_2 = 1;
                }
                else if (predictViewModel.Age >= 30 && predictViewModel.Age <= 34)
                {
                    predictionModel.Age_3 = 1;
                }
                else if (predictViewModel.Age >= 35 && predictViewModel.Age <= 39)
                {
                    predictionModel.Age_4 = 1;
                }
                else if (predictViewModel.Age >= 40 && predictViewModel.Age <= 44)
                {
                    predictionModel.Age_5 = 1;
                }
                else if (predictViewModel.Age >= 45 && predictViewModel.Age <= 49)
                {
                    predictionModel.Age_6 = 1;
                }
                else if (predictViewModel.Age >= 50 && predictViewModel.Age <= 54)
                {
                    predictionModel.Age_7 = 1;
                }
                else if (predictViewModel.Age >= 55 && predictViewModel.Age <= 59)
                {
                    predictionModel.Age_8 = 1;
                }
                else if (predictViewModel.Age >= 60 && predictViewModel.Age <= 64)
                {
                    predictionModel.Age_9 = 1;
                }
                else if (predictViewModel.Age >= 65 && predictViewModel.Age <= 69)
                {
                    predictionModel.Age_10 = 1;
                }
                else if (predictViewModel.Age >= 70 && predictViewModel.Age <= 74)
                {
                    predictionModel.Age_11 = 1;
                }
                else if (predictViewModel.Age >= 75 && predictViewModel.Age <= 79)
                {
                    predictionModel.Age_12 = 1;
                }
                else if (predictViewModel.Age >= 80)
                {
                    predictionModel.Age_13 = 1;
                }
                Prediction prediction = await _webApiHelper.PredictionGet(predictionModel);
                return View("Prediction");
            }
            else
            {
                return View();
            }
        }
        public IActionResult HowDoesItWork()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
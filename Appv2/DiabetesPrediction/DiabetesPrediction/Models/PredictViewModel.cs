using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DiabetesPrediction.Models
{
    public class PredictViewModel
    {
        [Required(ErrorMessage = "Please select your Height in centimeters.")]
        [DisplayName("What is your height in centimeters?")]
        [Range(50, 300, ErrorMessage = "The value should be between 50 and 300")]
        public int? Height { get; set; }

        [Required(ErrorMessage = "Please select your Weight in kilograms.")]
        [DisplayName("What is your weight in kilograms?")]
        [Range(10, 300, ErrorMessage = "The value should be between 10 and 300")]
        public int? Weight { get; set; }

        [Required(ErrorMessage = "Please select your physical health.")]
        [DisplayName("Now thinking about your physical health, which includes physical illness and injury, for how many days during the past 30 days was your physical not good?")]
        [Range(0, 30, ErrorMessage = "The value should be between 0 and 30")]
        public int? PhysHlth { get; set; }

        [Required(ErrorMessage = "Please select your DiffWalk.")]
        [DisplayName("Do you have any serious difficulty while walking or climbing stairs?")]
        public bool DiffWalk { get; set; }

        [Required(ErrorMessage = "Please select your Stroke.")]
        [DisplayName("Have you ever had a stroke?")]
        public bool Stroke { get; set; }

        [Required(ErrorMessage = "Please select your HeartDiseaseorAttack.")]
        [DisplayName("Do you have a coronary heart disease (CHD) or myocardial infarction (MI)?")]
        public bool HeartDiseaseorAttack { get; set; }

        [Required(ErrorMessage = "Please select your general health.")]
        [DisplayName("Would you say that in general your health is: scale 1-5 1 = excellent, 2 = very good, 3 = good, 4 = fair, 5 = poor.")]
        [Range(1, 5, ErrorMessage ="The value should be between 1 and 5")]
        public int? genHlth { get; set; }

        [Required(ErrorMessage = "Please select your Age.")]
        [DisplayName("What is your age?")]
        [Range(18, 120, ErrorMessage = "The value should be between 1 and 120")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please select your PhysActivity.")]
        [DisplayName("Have you done any physical activity in past 30 days - not including job?")]
        public bool PhysActivity { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DiabetesPrediction.Models
{
    public class PredictionModel
    {
        
        public double? BMI { get; set; }
       
        public int? PhysHlth { get; set; }

        public int DiffWalk { get; set; }

        public int Stroke { get; set; }

        public int PhysActivity { get; set; }
        public int HeartDiseaseorAttack { get; set; }

        public int? genHlth_1 { get; set; } = 0;
        public int? genHlth_2 { get; set; } = 0;
        public int? genHlth_3 { get; set; } = 0;
        public int? genHlth_4 { get; set; } = 0;
        public int? genHlth_5 { get; set; } = 0;

        public int? Age_1 { get; set; } = 0;
        public int? Age_2 { get; set; }= 0;
        public int? Age_3 { get; set; } = 0;
        public int? Age_4 { get; set; } = 0;
        public int? Age_5 { get; set; } = 0;
        public int? Age_6 { get; set; } = 0;
        public int? Age_7 { get; set; } = 0;
        public int? Age_8 { get; set; } = 0;
        public int? Age_9 { get; set; } = 0;
        public int? Age_10 { get; set; } = 0;
        public int? Age_11 { get; set; } = 0;
        public int? Age_12 { get; set; } = 0;
        public int? Age_13 { get; set; } = 0;
        

       
    }
}

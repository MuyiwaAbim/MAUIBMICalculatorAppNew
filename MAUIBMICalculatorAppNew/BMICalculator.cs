using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBMICalculatorAppNew
{
    public static class BMICalculator
    {
        public static double CalculateBMI(double weight, double height)
        {
            return (weight * 703) / (height * height);
        }

        public static string GetBMIStatus(double bmi, string gender)
        {
            if (gender == "Male")
            {
                if (bmi < 18.5) return "Underweight";
                if (bmi < 25) return "Normal weight";
                if (bmi < 30) return "Overweight";
                return "Obese";
            }
            else
            {
                if (bmi < 18) return "Underweight";
                if (bmi < 24) return "Normal weight";
                if (bmi < 29) return "Overweight";
                return "Obese";
            }
        }

        public static string GetHealthRecommendation(double bmi, string gender)
        {
            string status = GetBMIStatus(bmi, gender);

            switch (status)
            {
                case "Underweight":
                    return "Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, Underweight whole grains). Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
                case "Normal weight":
                    return "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health.";
                case "Overweight":
                    return "Reduce processed foods and focus on portion control. Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. Drink plenty of water and track your progress.";
                case "Obese":
                    return "Consult a doctor for personalized guidance. Start with low-impact exercises (e.g., walking, cycling). Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
                default:
                    return "No recommendation available.";
            }
        }
    }
}

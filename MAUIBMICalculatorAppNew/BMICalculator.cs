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

        
    }
}

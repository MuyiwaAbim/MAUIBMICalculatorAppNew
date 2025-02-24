using Microsoft.Maui.Controls;
using System;

namespace MAUIBMICalculatorAppNew
{
    public partial class BMIPage : ContentPage
    {
        public BMIPage(double bmi, string healthStatus)
        {
            InitializeComponent();

            BMIResultLabel.Text = $"Your BMI: {bmi:F1}";
            HealthStatusLabel.Text = $"Health Status: {healthStatus}";
        }

        private async void OnViewRecommendationsClicked(object sender, EventArgs e)
        {
            string recommendation = BMICalculator.GetHealthRecommendation(
                double.Parse(BMIResultLabel.Text.Replace("Your BMI: ", "")),
                HealthStatusLabel.Text.Replace("Health Status: ", "")
            );
            await Navigation.PushAsync(new HealthPage(recommendation));
        }

        private async void OnGoBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

using Microsoft.Maui.Controls;

namespace MAUIBMICalculatorAppNew
{
    public partial class MainPage : ContentPage
    {
        private string selectedGender = "Male"; 

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGenderSelected(object sender, EventArgs e)
        {
            var button = sender as ImageButton;

            if (button == MaleButton)
            {
                selectedGender = "Male";
                MaleButton.BorderColor = Colors.Blue;
                FemaleButton.BorderColor = Colors.Transparent;
            }
            else
            {
                selectedGender = "Female";
                FemaleButton.BorderColor = Colors.Pink;
                MaleButton.BorderColor = Colors.Transparent;
            }
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            WeightLabel.Text = $"{(int)WeightSlider.Value} lbs";
            HeightLabel.Text = $"{(int)HeightSlider.Value} inches";
        }

        // This calculate the BMI
        private async void OnCalculateBMI(object sender, EventArgs e)
        {
            double weight = WeightSlider.Value;  // Weight in lbs
            double height = HeightSlider.Value;  // Height in inches

            double bmi = (weight * 703) / (height * height);

            string healthStatus;
            string recommendation;

            if (bmi < 18.5)
            {
                healthStatus = "Underweight";
                recommendation = "Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains). Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                healthStatus = "Normal Weight";
                recommendation = "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health.";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                healthStatus = "Overweight";
                recommendation = "Reduce processed foods and focus on portion control. Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. Drink plenty of water and track your progress.";
            }
            else
            {
                healthStatus = "Obese";
                recommendation = "Consult a doctor for personalized guidance. Start with low-impact exercises (e.g., walking, cycling). Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
            }

            // Show Popup with BMI Details
            await DisplayAlert("BMI Result",
                $"Your BMI: {bmi:F1}\nHealth Status: {healthStatus}\nRecommendation: {recommendation}",
                "OK");
        }


    }
}

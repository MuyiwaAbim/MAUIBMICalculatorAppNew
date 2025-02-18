using Microsoft.Maui.Controls;

namespace MAUIBMICalculatorAppNew
{
    public partial class MainPage : ContentPage
    {
        private string selectedGender = "Male"; // Default gender
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGenderSelected(object sender, EventArgs e)
        {
            if (sender == MaleButton)
            {
                selectedGender = "Male";
                MaleButton.BorderColor = Colors.Blue;
                FemaleButton.BorderColor = Colors.Grey;
            }
            else if (sender == FemaleButton)
            {
                selectedGender = "Female";
                FemaleButton.BorderColor = Colors.Pink;
                MaleButton.BorderColor = Colors.Grey;
            }
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == WeightSlider)
            {
                WeightLabel.Text = $"{(int)WeightSlider.Value} lbs";
            }
            else if (sender == HeightSlider)
            {
                HeightLabel.Text = $"{(int)HeightSlider.Value} inches";
            }
        }

        private async void OnCalculateBMI(object sender, EventArgs e)
        {
            double weight = WeightSlider.Value;
            double height = HeightSlider.Value;
            double bmi = (weight / (height * height)) * 703;

            string bmiStatus = BMICalculator.GetBMIStatus(bmi, selectedGender);
            await Navigation.PushAsync(new BMIPage(bmi, bmiStatus));

        }
    }
}

namespace MAUIBMICalculatorAppNew;

public partial class HealthPage : ContentPage
{
    public HealthPage(string recommendation)
    {
        InitializeComponent();

        // Display the personalized health recommendation
        RecommendationLabel.Text = recommendation;
    }

    private async void OnBackToResultsClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Go back to BMI Results Page
    }

    private async void OnBackToMainPageClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); // Go back to Main Page
    }
}

namespace MAUIBMICalculatorAppNew;

public partial class HealthPage : ContentPage
{
    public HealthPage(string recommendation)
    {
        InitializeComponent();

        RecommendationLabel.Text = recommendation;
    }

    private async void OnBackToResultsClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); 
    }

    private async void OnBackToMainPageClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); 
    }
}

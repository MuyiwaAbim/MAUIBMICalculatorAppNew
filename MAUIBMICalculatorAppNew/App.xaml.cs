﻿namespace MAUIBMICalculatorAppNew;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        return new Window(new AppShell()); // Ensure AppShell is used for navigation
    }
}

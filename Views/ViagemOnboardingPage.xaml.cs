using ViagemOnboarding.ViewModels;

namespace ViagemOnboarding.Views;

public partial class ViagemOnboardingPage : ContentPage
{
    public ViagemOnboardingPage(ViagemOnboardingViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
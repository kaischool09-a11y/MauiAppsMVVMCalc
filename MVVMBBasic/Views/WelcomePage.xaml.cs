using ViewModels;

namespace Views;

public partial class WelcomePage : ContentPage
{
    public WelcomePage() : this(new WelcomeViewModel())
    {
    }

    // קבלת ה-ViewModel ישירות דרך Dependency Injection וחיבור ה-Binding Context
    public WelcomePage(WelcomeViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
using ViewModels;

namespace Views;

public partial class TemperaturePage : ContentPage
{
    public TemperaturePage() : this(new TemperatureViewModel())
    {
    }

    public TemperaturePage(TemperatureViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
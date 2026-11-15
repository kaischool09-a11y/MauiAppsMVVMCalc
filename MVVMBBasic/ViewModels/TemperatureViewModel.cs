
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ViewModels;

public class TemperatureViewModel : INotifyPropertyChanged
{
    private string _fahrenheit = "";
    private string _celsius = ""; 

    public string Fahrenheit
    {
        get => _fahrenheit;
        set
        {
            _fahrenheit = value;
            OnPropertyChanged();
        }
    }

    public string Celsius
    {
        get => _celsius;
        set
        {
            _celsius = value;
            OnPropertyChanged();
        }
    }

    public ICommand ConvertCommand { get; }

    public TemperatureViewModel()
    {
        ConvertCommand = new Command(ConvertTemperature);
    }

    private void ConvertTemperature()
    {
        if (double.TryParse(Fahrenheit, out double f))
        {
            double c = (f - 32) * 5 / 9;
            Celsius = $"{c:F2} °C";
        }
        else
        {
            Celsius = "נא להזין טמפרטורה תקינה";
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(
            this, new PropertyChangedEventArgs(propertyName));
    }
}

using System.Windows.Input;

namespace ViewModels
{
    public class WelcomeViewModel
    {
        public ICommand NavigateToMathCalcCommand { get; }
        public ICommand NavigateToCalcAgeCommand { get; }
        public ICommand NavigateToConvertCommand { get; }

        public WelcomeViewModel()
        {

            NavigateToMathCalcCommand = new Command(async () => await Shell.Current.GoToAsync("///CalculatorPage"));

            NavigateToCalcAgeCommand = new Command(async () => await Shell.Current.GoToAsync("//CalcAge"));

            NavigateToConvertCommand = new Command(async () => await Shell.Current.GoToAsync("//TemperaturePage"));

        }
    }
}

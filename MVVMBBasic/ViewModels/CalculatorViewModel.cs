using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private string _number1;
        private string _number2;
        private string _result;

        public string Number1
        {
            get => _number1;
            set { _number1 = value; OnPropertyChanged(); }
        }

        public string Number2
        {
            get => _number2;
            set { _number2 = value; OnPropertyChanged(); }
        }

        public string Result
        {
            get => _result;
            set { _result = value; OnPropertyChanged(); }
        }

        public ICommand CalculateCommand { get; }

        public CalculatorViewModel()
        {
            CalculateCommand = new Command<string>(ExecuteCalculate);
        }

        private void ExecuteCalculate(string operation)
        {
            if (double.TryParse(Number1, out double n1) && double.TryParse(Number2, out double n2))
            {
                double res = operation switch
                {
                    "+" => n1 + n2,
                    "-" => n1 - n2,
                    "*" => n1 * n2,
                    "/" => n2 != 0 ? n1 / n2 : 0,
                    _ => 0
                };
                Result = $"התוצאה היא: {res}";
            }
            else
            {
                Result = "נא להזין מספרים תקינים";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

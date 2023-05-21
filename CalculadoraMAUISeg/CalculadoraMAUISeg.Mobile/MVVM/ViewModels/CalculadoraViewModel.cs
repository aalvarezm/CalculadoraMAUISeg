using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace CalculadoraMAUISeg.Mobile.MVVM.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private string _display;

        public string Display
        {
            get { return _display; }
            set
            {
                if (_display != value)
                {
                    _display = value;
                    OnPropertyChanged(nameof(Display));
                }
            }
        }

        public ICommand NumberCommand { get; }
        public ICommand OperationCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand EqualsCommand { get; }

        private double _firstNumber;
        private string _operation;

        public CalculatorViewModel()
        {
            Display = "0";
            NumberCommand = new Command<string>(HandleNumberCommand);
            OperationCommand = new Command<string>(HandleOperationCommand);
            ClearCommand = new Command(HandleClearCommand);
            EqualsCommand = new Command(HandleEqualsCommand);
        }

        private void HandleNumberCommand(string number)
        {
            if (Display == "0" || _operation == "=")
            {
                Display = number;
            }
            else
            {
                Display += number;
            }
        }

        private void HandleOperationCommand(string operation)
        {
            _firstNumber = double.Parse(Display);
            _operation = operation;
            Display = "0";
        }

        private void HandleClearCommand()
        {
            Display = "0";
            _operation = null;
        }

        private void HandleEqualsCommand()
        {
            if (_operation != null)
            {
                double secondNumber = double.Parse(Display);
                double result = 0;

                switch (_operation)
                {
                    case "+":
                        result = _firstNumber + secondNumber;
                        break;
                    case "-":
                        result = _firstNumber - secondNumber;
                        break;
                    case "*":
                        result = _firstNumber * secondNumber;
                        break;
                    case "/":
                        result = _firstNumber / secondNumber;
                        break;
                }

                Display = result.ToString();
                _operation = "=";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

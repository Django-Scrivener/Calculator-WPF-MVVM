using Calculator_WPF_MVVM.Commands;
using System.Windows.Input;

namespace Calculator_WPF_MVVM.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        private int _result;
        public int  Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
        public ICommand AddCommand { get; }

        public CalculatorViewModel()
        {
            AddCommand = new CalculateResultCommand();
        }
    }
}

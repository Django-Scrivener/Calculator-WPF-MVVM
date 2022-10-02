using Calculator_WPF_MVVM.Commands;
using System.Windows.Input;

namespace Calculator_WPF_MVVM.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        private int? _fieldA = null;
        public int? FieldA
        {
            get
            {
                return _fieldA;
            }
            set
            {
                _fieldA = value;
                OnPropertyChanged(nameof(FieldA));
            }
        }

        private int? _fieldB = null;
        public int? FieldB
        {
            get
            {
                return _fieldB;
            }
            set
            {
                _fieldB = value;
                OnPropertyChanged(nameof(FieldB));
            }
        }

        private int? _result = null;
        public int? Result
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
            AddCommand = new CalculateResultCommand(this);
        }
    }
}

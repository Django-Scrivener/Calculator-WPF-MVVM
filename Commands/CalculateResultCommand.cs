using Calculator_WPF_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator_WPF_MVVM.Commands
{
    public class CalculateResultCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly CalculatorViewModel _calculatorViewModel;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public CalculateResultCommand(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }

        public void Execute(object parameter)
        {
            //int result = int.Parse(_calculatorViewModel.FieldA) + int.Parse(_calculatorViewModel.FieldB);
            //_calculatorViewModel.Result = result.ToString();

            _calculatorViewModel.Result = _calculatorViewModel.FieldA + _calculatorViewModel.FieldB;
        }
    }
}
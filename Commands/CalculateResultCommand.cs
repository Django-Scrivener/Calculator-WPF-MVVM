using Calculator_WPF_MVVM.ViewModels;

namespace Calculator_WPF_MVVM.Commands
{
    public class CalculateResultCommand : CommandBase
    {
        private readonly CalculatorViewModel _calculatorViewModel;

        public override void Execute(object? parameter)
        {
            _calculatorViewModel.Result = _calculatorViewModel.FieldA + _calculatorViewModel.FieldB;
        }

        public CalculateResultCommand(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }
    }
}
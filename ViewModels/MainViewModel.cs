namespace Calculator_WPF_MVVM.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new CalculatorViewModel();
        }
    }
}

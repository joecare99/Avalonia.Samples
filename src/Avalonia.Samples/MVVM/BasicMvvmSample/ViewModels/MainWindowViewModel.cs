namespace BasicMvvmSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        // Add our SimpleViewModel.
        // Note: We need at least a get-accessor for our Properties.
        public SimpleViewModel SimpleViewModel { get; } = new SimpleViewModel();
        
        // Add our ReactiveViewModel
        public ReactiveViewModel ReactiveViewModel { get; } = new ReactiveViewModel();

        // Add our Community-Toolkit-ViewModel
        public CTViewModel CTViewModel { get; } = new CTViewModel();
    }
}

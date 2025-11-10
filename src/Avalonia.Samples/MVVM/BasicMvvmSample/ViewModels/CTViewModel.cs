using CommunityToolkit.Mvvm.ComponentModel;

namespace BasicMvvmSample.ViewModels
{
    // This is our ViewModel. It inherits from "ObservableObject" which implements "INotifyPropertyChanged"
    // in order to notify the View if any of our properties changed.
    public partial class CTViewModel : ObservableObject
    {

        // ---- Add some Properties ----
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Greeting))]
        private string? _Name; // This is our backing field for Name and "Name" will be automatically implemented.

        // Greeting will change based on a Name.
        public string Greeting 
            => string.IsNullOrEmpty(Name) ? "Hello World from Avalonia.Samples" : $"Hello {Name}";
    }
}

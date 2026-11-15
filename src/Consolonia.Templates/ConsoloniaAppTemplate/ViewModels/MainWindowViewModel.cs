using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ConsoloniaAppTemplate.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty] private int _clickCount;

        [ObservableProperty] private string _greeting = "Welcome to Consolonia!";

        [RelayCommand]
        private void Increment()
        {
            ClickCount++;
        }
    }
}

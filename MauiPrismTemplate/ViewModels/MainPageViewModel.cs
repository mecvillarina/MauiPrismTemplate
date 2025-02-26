using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiPrismTemplate.Services;

namespace MauiPrismTemplate.ViewModels;

public partial class MainPageViewModel : PageViewModelBase
{
    public MainPageViewModel(BaseServices baseServices) : base(baseServices)
    {
    }

    private int _count;

    [ObservableProperty]
    private string _counterBtnText = "Click me";
    
    [RelayCommand(AllowConcurrentExecutions = false)]
    private async Task CounterTapped()
    {
        _count++;

        if (_count == 1)
            CounterBtnText = $"Clicked {_count} time";
        else
            CounterBtnText = $"Clicked {_count} times";

        SemanticScreenReader.Announce(CounterBtnText);
    }
    
    [RelayCommand]
    private async Task NavigateToSecondPage()
    {
        await NavigationService.NavigateAsync("SecondPage");
    }
}

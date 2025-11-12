using MauiPlayground.Views;

namespace MauiPlayground.ViewModels;

public class ToolbarItemPageViewModel : BaseViewModel
{
    public DelegateCommand SecondPageCommand { get; }
    
    public ToolbarItemPageViewModel(INavigationService navigationService) 
        : base(navigationService)
    {
        SecondPageCommand = new DelegateCommand(OnSecondPageCommand);
    }

    private async void OnSecondPageCommand()
    {
        var result = await NavigationService.CreateBuilder()
            .AddSegment(nameof(SecondPage), true)
            .NavigateAsync();
    }
}
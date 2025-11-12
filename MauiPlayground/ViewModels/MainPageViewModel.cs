using MauiPlayground.Views;

namespace MauiPlayground.ViewModels;

public class MainPageViewModel : BaseViewModel
{
    public DelegateCommand ToolbarItemPageCommand { get; }
    
    public MainPageViewModel(INavigationService navigationService) 
        : base(navigationService)
    {
        ToolbarItemPageCommand = new DelegateCommand(OnToolbarItemPageCommand);
    }

    

    #region Commands
    
    private async void OnToolbarItemPageCommand()
    {
        var result = await NavigationService.CreateBuilder()
            .AddSegment(nameof(ToolbarItemPage))
            .NavigateAsync();
    }
    
    #endregion
    
}
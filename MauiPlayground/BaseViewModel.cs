namespace MauiPlayground;

public class BaseViewModel
{
    protected readonly INavigationService NavigationService;

    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }
}
using System.Windows.Input;
using GoBackNavigation.Views;

namespace GoBackNavigation.ViewModels;

public class FirstPageViewModel
{
    private readonly INavigationService _navigationService;

    public FirstPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    #region NavigateCommand

    public ICommand NavigateCommand => new DelegateCommand<object>(ExecuteNavigate);

    private void ExecuteNavigate(object obj)
    {
        _navigationService.CreateBuilder().AddSegment<SecondPage>().NavigateAsync(OnSuccess, OnError);
    }

    private void OnError(Exception obj)
    {
        
    }

    private void OnSuccess()
    {
        
    }

    #endregion
}

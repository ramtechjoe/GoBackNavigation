using System.Diagnostics;
using GoBackNavigation.Views;

namespace GoBackNavigation.ViewModels;

public class MainPageViewModel : BindableBase
{
    private readonly INavigationService _navigationService;
    private ISemanticScreenReader _screenReader { get; }
    private int _count;

    public MainPageViewModel(ISemanticScreenReader screenReader, INavigationService navigationService)
    {
        _navigationService = navigationService;
        _screenReader = screenReader;
        CountCommand = new DelegateCommand(OnCountCommandExecuted);
    }

    public string Title => "Main Page";

    private string _text = "Click me";
    public string Text
    {
        get => _text;
        set => SetProperty(ref _text, value);
    }

    public DelegateCommand CountCommand { get; }

    private void OnCountCommandExecuted()
    {
        _navigationService.CreateBuilder().AddSegment<FirstPage>()
            .NavigateAsync(OnSuccess, OnError);
    }

    private void OnError(Exception obj)
    {
        Trace.WriteLine(obj);
    }

    private void OnSuccess()
    {
        Trace.WriteLine("Hi");
    }
}

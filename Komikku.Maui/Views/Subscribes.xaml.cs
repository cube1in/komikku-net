using Komikku.Maui.ViewModels;

namespace Komikku.Maui.Views;

public partial class Subscribes : ContentPage
{
    private SubscribesViewModel ViewModel => (BindingContext as SubscribesViewModel)!;

    public Subscribes(SubscribesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await ViewModel.InitializeAsync();
    }
}
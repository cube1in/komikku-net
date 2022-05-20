using Komikku.Maui.ViewModels;

namespace Komikku.Maui.Views;

public partial class Details : ContentPage
{
    private DetailsViewModel ViewModel => (BindingContext as DetailsViewModel)!;

    public Details(DetailsViewModel viewModel)
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
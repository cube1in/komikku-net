using Komikku.Maui.ViewModels;

namespace Komikku.Maui.Views;

public partial class Reading : ContentPage
{
    private ReadingViewModel ViewModel => (BindingContext as ReadingViewModel)!;

    public Reading(ReadingViewModel viewModel)
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
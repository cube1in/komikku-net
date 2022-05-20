using Komikku.Maui.ViewModels;

namespace Komikku.Maui.Views;

public partial class Me : ContentPage
{
    private MeViewModel ViewModel => (BindingContext as MeViewModel)!;

    public Me(MeViewModel viewModel)
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
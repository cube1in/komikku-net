using Komikku.Maui.ViewModels;

namespace Komikku.Maui.Views;

public partial class LatestUpdate : ContentPage
{
    public LatestUpdate(LatestUpdateViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
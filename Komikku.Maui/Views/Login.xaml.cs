using Komikku.Maui.ViewModels;

namespace Komikku.Maui.Views;

public partial class Login : ContentPage
{
    public Login(LoginViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
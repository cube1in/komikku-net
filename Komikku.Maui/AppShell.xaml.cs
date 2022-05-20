using Komikku.Maui.ViewModels;

namespace Komikku.Maui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        BindingContext = new ShellViewModel();
    }
}

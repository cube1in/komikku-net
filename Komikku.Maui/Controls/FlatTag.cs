using System.Runtime.CompilerServices;

namespace Komikku.Maui.Controls;

public class FlatTag : ContentView
{
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(FlatTag), string.Empty);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        if (propertyName == TextProperty.PropertyName)
        {
            // TODO: Better way to get control?
            // ((Frame)Children[0]).Children[0]
            ((Label)((Frame)Content).Content).Text = Text;
        }
    }

    public FlatTag()
    {
        Content = new Frame
        {
            Padding = 0,
            BackgroundColor = Colors.LightGray,
            CornerRadius = 2,
            HasShadow = false,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,

            Content = new Label
            {
                Margin = 5,
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                LineBreakMode = LineBreakMode.TailTruncation,
                MaxLines = 1,
                TextColor = Colors.Black,
            }
        };
    }
}

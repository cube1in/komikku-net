using System.Globalization;

namespace Komikku.Maui.ValueConverters;

public class SubscribeButtonTextToIsAuthenticatedCoverter : BaseValueConverter<SubscribeButtonTextToIsAuthenticatedCoverter>
{
    public override object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value switch
        {
            string str => str switch
            {
                "登录可订阅" => false,
                _ => true
            },
            _ => throw new NotSupportedException()
        };
    }

    public override object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

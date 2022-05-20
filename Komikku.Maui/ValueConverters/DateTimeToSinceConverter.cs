using System.Globalization;

namespace Komikku.Maui.ValueConverters;

public class DateTimeToSinceConverter : BaseValueConverter<DateTimeToSinceConverter>
{
    public override object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is DateTime dateTime ||
            value is string str && DateTime.TryParse(str, out dateTime))
        {
            var hours = (int)DateTime.Now.Subtract(dateTime).TotalHours;
            if (hours >= 24) return $"{hours / 24}天之前";
            if (hours >= 720) return $"{hours / 720}月之前";
            return $"{hours}小时之前";
        }

        return string.Empty;
    }

    public override object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

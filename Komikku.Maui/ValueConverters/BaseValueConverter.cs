using System.Globalization;

namespace Komikku.Maui.ValueConverters;

public abstract class BaseValueConverter<T> : IMarkupExtension<T>, IValueConverter
    where T : class, new()
{
    #region Private Members

    /// <summary>
    /// 一个单例的 <see cref="IValueConverter"/>
    /// </summary>
    private static T? _converter;


    #endregion

    #region IValueConverter Methods

    /// <summary>
    /// 从一个类型转换到另一个类型
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public abstract object? Convert(object value, Type targetType, object parameter, CultureInfo culture);

    /// <summary>
    /// 从转换后的类型转换到源类型
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public abstract object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

    #endregion

    #region IMarkupExtension Methods

    /// <summary>
    /// 提供一个 <see cref="IValueConverter"/> 的实例
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <returns></returns>
    public T ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ??= new T();
    }

    /// <summary>
    /// 提供一个 <see cref="IValueConverter"/> 的实例
    /// </summary>
    /// <param name="serviceProvider"></param>
    /// <returns></returns>
    object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ??= new T();
    }

    #endregion
}

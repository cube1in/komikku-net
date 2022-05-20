using CommunityToolkit.Mvvm.ComponentModel;
using PropertyChanged;
using System.Linq.Expressions;
using System.Reflection;

namespace Komikku.Maui.ViewModels;

[AddINotifyPropertyChangedInterface]
[ObservableObject]
public abstract partial class BaseViewModel
{
    /// <summary>
    /// 是否在加载页面
    /// </summary>
    [AlsoNotifyFor(nameof(IsLoaded))]
    public bool IsLoading { get; set; }

    /// <summary>
    /// 是否在加载完成
    /// </summary>
    public bool IsLoaded => !IsLoading;

    /// <summary>
    /// 是否在忙
    /// </summary>
    [AlsoNotifyFor(nameof(IsLoaded))]
    public bool IsBusy { get; set; }

    /// <summary>
    /// 是否不在忙
    /// </summary>
    public bool IsNotBusy => !IsBusy;

    /// <summary>
    /// 如果未设置更新标志，则运行命令
    /// 如果标志为真（表明该函数已在运行），则该操作不会运行
    /// 如果标志为假（表示没有正在运行的函数），则运行该操作
    /// 如果操作已运行，则一旦完成操作，则标志将重置为 false
    /// </summary>
    /// <param name="updatingFlag">定义命令是否已在运行的标志</param>
    /// <param name="action">如果命令尚未运行，则要运行的操作</param>
    /// <returns></returns>
    public static async Task Run(Expression<Func<bool>> updatingFlag, Func<Task> action)
    {
        if (updatingFlag.GetPropertyValue())
            return;

        // 设置 flag 为 true，表示正在运行
        updatingFlag.SetPropertyValue(true);

        try
        {
            // 运行 action
            await action();
        }
        finally
        {
            // 最后设置 flag 为 false
            updatingFlag.SetPropertyValue(false);
        }
    }
}

/// <summary>
/// 表达式帮助类
/// </summary>
public static class ExpressionHelpers
{
    /// <summary>
    /// 编译表达式并获取函数返回值
    /// </summary>
    /// <typeparam name="T">返回值的类型</typeparam>
    /// <param name="lambda">要编译的表达式</param>
    /// <returns></returns>
    public static T GetPropertyValue<T>(this Expression<Func<T>> lambda)
    {
        return lambda.Compile().Invoke();
    }

    /// <summary>
    /// 将属性值设置为给定值
    /// </summary>
    /// <typeparam name="T">返回值的类型</typeparam>
    /// <param name="lambda">要编译的表达式</param>
    /// <param name="value">要设置的值</param>
    public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
    {
        // 将 lambda () => some.Property 转为 some.Property
        var expression = lambda.Body as MemberExpression;

        // 获取属性信息，用于设置
        var propertyInfo = expression?.Member as PropertyInfo;

        // 获取目标类
        var target = (expression?.Expression as ConstantExpression)?.Value;

        // 设置
        propertyInfo?.SetValue(target, value);
    }
}
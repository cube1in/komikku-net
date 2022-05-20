using CommunityToolkit.Mvvm.Input;
using Komikku.Kernel;
using Komikku.Kernel.Apis;
using Komikku.Maui.DataAccess;
using Komikku.Maui.Views;
using Refit;
using System.Windows.Input;

namespace Komikku.Maui.ViewModels;

/// <summary>
/// 我的视图模型
/// </summary>
public class MeViewModel : BaseViewModel
{
    #region Private Members

    /// <summary>
    /// 用户认证提供器
    /// </summary>
    private readonly IAuthApi _authApi;

    /// <summary>
    /// 验证管理
    /// </summary>
    private readonly AuthorizeManager _authorizeManager;

    #endregion

    #region Public Properties

    /// <summary>
    /// 认证栏文本
    /// </summary>
    public string AuthTabText { get; set; } = "前往登录";

    #endregion

    #region Commands

    /// <summary>
    /// 认证栏命令
    /// </summary>
    public ICommand LoginCommand => new AsyncRelayCommand(AuthorizeLoginAsync);

    #endregion

    #region Constructor

    /// <summary>
    /// 默认构造函数
    /// </summary>
    public MeViewModel(AuthorizeManager authorizeManager)
    {
        _authorizeManager = authorizeManager;
        _authApi = RestService.For<IAuthApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// 认证是否登录
    /// </summary>
    /// <returns></returns>
    private async Task AuthorizeLoginAsync()
    {
        await Run(() => IsBusy, async () =>
        {
            switch (await _authorizeManager.IsLoginAsync())
            {
                case true:
                    var result1 = await Shell.Current.DisplayAlert("登出", "登出后无法查看订阅", "确定登出", "再想想");
                    if (result1)
                    {
                        await _authorizeManager.LogoutAsync();
                        AuthTabText = "前往登录";
                        _ = _authApi.LogoutAsync((await _authorizeManager.GetTokenAsync())!);
                    }

                    break;
                case false:
                    await Shell.Current.GoToAsync(nameof(Login), true);
                    break;
            }
        });
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// 初始化
    /// </summary>
    /// <returns></returns>
    internal async Task InitializeAsync()
    {
        AuthTabText = await _authorizeManager.IsLoginAsync() switch
        {
            true => "登出",
            false => "前往登录"
        };
    }

    #endregion
}

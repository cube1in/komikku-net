using CommunityToolkit.Mvvm.Input;
using Komikku.Kernel;
using Komikku.Kernel.Apis;
using Komikku.Kernel.Models;
using Komikku.Maui.DataAccess;
using Refit;
using System.Windows.Input;

namespace Komikku.Maui.ViewModels;

/// <summary>
/// 登录视图模型
/// </summary>
public class LoginViewModel : BaseViewModel
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
    /// 用户名
    /// </summary>
    public string? Username { get; set; }

    /// <summary>
    /// 邮箱地址
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    public string? Password { get; set; }

    #endregion

    #region Commands

    /// <summary>
    /// 登录命令
    /// </summary>
    public ICommand LoginCommand => new AsyncRelayCommand(LoginAsync);

    #endregion

    #region Construction

    /// <summary>
    /// 默认构造函数
    /// </summary>
    public LoginViewModel(AuthorizeManager authorizeManager)
    {
        _authorizeManager = authorizeManager;
        _authApi = RestService.For<IAuthApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);
    }

    /// <summary>
    /// 命令执行
    /// </summary>
    /// <returns></returns>
    private async Task LoginAsync()
    {
        await Run(() => IsBusy, async () =>
        {
            if (string.IsNullOrWhiteSpace(Username) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Password))
            {
                await Shell.Current.DisplayAlert("信息", "请输入完整信息！", "确认");
                return;
            }

            try
            {
                var auth = await _authApi.LoginAsync(new Login
                {
                    Username = Username,
                    Email = Email,
                    Password = Password
                });

                if (auth?.Result == Result.Ok)
                {
                    // Set token
                    await _authorizeManager.CacheSessionAsync(auth.Token.Session);
                    await _authorizeManager.SetRefrshAsync(auth.Token.Refresh);

                    await Shell.Current.DisplayAlert("成功", $"欢迎，{Username}！", "确认");
                    await Shell.Current.Navigation.PopToRootAsync(true);
                }
            }
            catch
            {
                await Shell.Current.DisplayAlert("失败", "请输入正确的信息！", "确认");
            }
        });
    }

    #endregion
}

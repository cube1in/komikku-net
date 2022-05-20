using Komikku.Kernel.Models;
using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

public class AuthApiTest
{
    private readonly IAuthApi _authApi = RestService.For<IAuthApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Theory]
    [InlineData("", "", "")]
    internal async void LoginTest(string username, string email, string password)
    {
        var login = new Login
        {
            Username = username,
            Email = email,
            Password = password
        };
        var token = await _authApi.LoginAsync(login);
        Assert.NotNull(token?.Token.Refresh);
    }
}
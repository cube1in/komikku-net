using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 设置
/// </summary>
public class SettingsApiTest : BaseForTest
{
    private readonly ISettingsApi _settingsApi =
        RestService.For<ISettingsApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Fact]
    internal async void LatestSettingsTemplateTest()
    {
        var template = await _settingsApi.GetLatestSettingsTemplateAsync(Token);
        Assert.NotNull(template);
    }

    [Theory]
    [InlineData("")]
    internal async void CreateSettingsTemplateTest(string jsonSchema)
    {
        var template = await _settingsApi.CreateSettingsTemplateAsync(Token, jsonSchema);
        Assert.NotNull(template);
    }

    [Theory]
    [InlineData("")]
    internal async void SettingsTemplateByVersionIdTest(string version)
    {
        var template = await _settingsApi.GetSettingsTemplateByVersionIdAsync(Token, version);
        Assert.NotNull(template);
    }

    [Fact]
    internal async void UserSettingsTest()
    {
        var settings = await _settingsApi.GetUserSettingsAsync(Token);
        Assert.NotNull(settings);
    }
}
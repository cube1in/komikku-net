using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 反应服务器健康状况
/// 与其他 Provider 独立
/// </summary>
public class HealthTrackerApi
{
    private static readonly HttpClient Client = new();

    /// <summary>
    /// 报告健康
    /// </summary>
    /// <param name="report"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task ReportAsync(HealthReport report, CancellationToken cancellationToken = default)
    {
        var jsonString = JsonConvert.SerializeObject(report, KernelSettings.SerializerSettings);
        var response = await Client.PostAsync("https://api.mangadex.network/report",
            new StringContent(jsonString, null, "application/json"), cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}

public class HealthReport
{
    /// <summary>
    /// 图像的完整网址
    /// </summary>
    public string Url { get; set; } = null!;

    /// <summary>
    /// 是否已成功检索映像
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 检索到的图像的大小（以字节为单位）
    /// </summary>
    public int Bytes { get; set; }

    /// <summary>
    /// 此图像的完整检索（不是 TTFB）所花费的时间（以毫秒为单位）
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// true如果服务器返回了一个标头，其值以 X-Cache HIT
    /// </summary>
    public bool Cached => Success;
}
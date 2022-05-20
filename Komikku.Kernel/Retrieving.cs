namespace Komikku.Kernel;

public static class Retrieving
{
    /// <summary>
    /// 封面原图
    /// </summary>
    /// <param name="mangaId"></param>
    /// <param name="filename"></param>
    /// <returns></returns>
    public static string GetCoverOnOriginal(string mangaId, string filename)
        => $"{KernelSettings.RetrievingCoverUrl}/{mangaId}/{filename}";

    /// <summary>
    /// 封面 512px 图片
    /// </summary>
    /// <param name="mangaId"></param>
    /// <param name="filename"></param>
    /// <returns></returns>
    public static string GetCoverOn512(string mangaId, string filename)
        => $"{KernelSettings.RetrievingCoverUrl}/{mangaId}/{filename}.512.jpg";

    /// <summary>
    /// 封面 256px 图片
    /// </summary>
    /// <param name="mangaId"></param>
    /// <param name="filename"></param>
    /// <returns></returns>
    public static string GetCoverOn256(string mangaId, string filename)
        => $"{KernelSettings.RetrievingCoverUrl}/{mangaId}/{filename}.256.jpg";

    /// <summary>
    /// 获取章节图片
    /// 质量模式
    /// </summary>
    /// <param name="baseUrl"></param>
    /// <param name="hash"></param>
    /// <param name="filenames"></param>
    /// <returns></returns>
    public static IEnumerable<string> GetChapterPagesOnDataQualityMode(string baseUrl, string hash, IEnumerable<string> filenames)
    {
        return from filename in filenames select $"{baseUrl}/data/{hash}/{filename}";
    }

    /// <summary>
    /// 获取章节图片
    /// 压缩模式
    /// </summary>
    /// <param name="baseUrl"></param>
    /// <param name="hash"></param>
    /// <param name="filenames"></param>
    /// <returns></returns>
    public static IEnumerable<string> GetChapterPagesOnDataSaverQualityMode(string baseUrl, string hash, IEnumerable<string> filenames)
    {
        return from filename in filenames select $"{baseUrl}/data-saver/{hash}/{filename}";
    }
}

/// <summary>
/// 图片质量
/// </summary>
public enum QualityMode
{
    /// <summary>
    /// 原始质量
    /// 注意：在使用中，此值为"data"
    /// </summary>
    Original,

    /// <summary>
    /// 压缩
    /// 注意：在使用中，此值为"data-saver"
    /// </summary>
    Compressed
}

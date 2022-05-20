namespace Komikku.Maui;

internal static class AppSettings
{
    public const string SessionToken = "session_token";

    public const string RefreshToken = "refresh_token";

    public static DateTimeOffset SessionTokenExpireTime => DateTimeOffset.Now.AddMinutes(14);

    public static DateTimeOffset RefreshTokenExpireTime => DateTimeOffset.UtcNow.AddDays(29);

    public static DateTimeOffset CacheAbsoluteExpiry = DateTimeOffset.UtcNow.AddDays(1);

    public static string PersonalFolder
    {
        // Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        // In android: /data/user/0/com.sou1maker.manguwa/files
        // In windows: C:\Users\sou1m\Documents
        // In IOS: Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "data.db");

        get
        {
            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library");
            }

            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }
    }
}

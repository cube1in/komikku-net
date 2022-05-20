using System.Collections.ObjectModel;

namespace Komikku.Maui.ViewModels;

/// <summary>
/// 漫画卷组
/// </summary>
public class ChapterGroupForDisplay : ObservableCollection<ChapterForDisplay>
{
    public string Volume { get; set; }

    public ChapterGroupForDisplay(string volume, IEnumerable<ChapterForDisplay> chapters)
        : base(chapters)
    {
        Volume = volume;
    }
}
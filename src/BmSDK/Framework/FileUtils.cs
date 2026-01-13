namespace BmSDK.Framework;

public static class FileUtils
{
    static string s_exeDir = "";

    internal static void Init()
    {
        s_exeDir = Path.GetFullPath(Environment.CurrentDirectory);
    }

    /// <summary>
    /// Returns the full path to the game directory (./).
    /// </summary>
    public static string GetBasePath()
    {
        return Path.GetFullPath(Path.Combine(s_exeDir, "..", ".."));
    }

    /// <summary>
    /// Returns the full path to the binaries directory (./Binaries/Win32/).
    /// </summary>
    public static string GetBinariesPath()
    {
        return Path.Combine(GetBasePath(), "Binaries", "Win32");
    }

    /// <summary>
    /// Returns the full path to the game directory (./BmGame/).
    /// </summary>
    public static string GetGamePath()
    {
        return Path.Combine(GetBasePath(), "BmGame");
    }
}

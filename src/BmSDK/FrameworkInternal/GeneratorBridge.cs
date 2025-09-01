namespace BmSDK.Framework;

internal static class GeneratorBridge
{
    const string FlagFileName = ".no-generate";
    static string FlagFilePath => Path.Combine(FileUtils.GetBasePath(), FlagFileName);

    public static bool IsGeneratorPresent =>
        File.Exists(Path.Combine(FileUtils.GetBinariesPath(), "plugins", "BmSDK.Generator.asi"));

    public static void DisableGenerator()
    {
        // TODO: Find a better way to handle this.
        // NOTE: It's important that enabled stays the "default" state so we don't introduce a circular build dependency.
        if (File.Exists(FlagFilePath))
        {
            Debug.LogWarning("Generator is already disabled");
            return;
        }

        File.Create(FlagFilePath);
    }

    public static void EnableGenerator()
    {
        if (!File.Exists(FlagFilePath))
        {
            Debug.LogWarning("Generator is already enabled");
            return;
        }

        File.Delete(FlagFilePath);
    }
}

namespace BmSDK.Framework;

internal static class GeneratorBridge
{
    public static bool IsGeneratorPresent =>
        File.Exists(Path.Combine(FileUtils.GetBinariesPath(), "plugins", "BmSDK.Generator.asi"));
}

using Tomlyn;
using Tomlyn.Model;

namespace BmSDK.Framework;

/// <summary>
/// Represents a loaded mod and its configuration.
/// </summary>
public sealed class Mod
{
    /// <summary>
    /// The display name of this mod, from mod.toml or the directory name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Full path to this mod's directory.
    /// </summary>
    public string DirectoryPath { get; }

    /// <summary>
    /// The full parsed mod.toml as a TOML table. Empty for the implicit Scripts mod.
    /// </summary>
    public TomlTable Config { get; }

    internal Mod(string name, string directoryPath, TomlTable config)
    {
        Name = name;
        DirectoryPath = directoryPath;
        Config = config;
    }

    internal static Mod FromDirectory(string modDir)
    {
        var tomlPath = Path.Combine(modDir, "mod.toml");
        var tomlText = File.ReadAllText(tomlPath);
        var config = TomlSerializer.Deserialize<TomlTable>(tomlText)!;

        var name =
            (config.TryGetValue("name", out var nameObj) && nameObj is string nameStr)
                ? nameStr
                : Path.GetFileName(modDir)!;

        return new Mod(name, modDir, config);
    }

    internal static Mod CreateDefault(string scriptsDir)
    {
        return new Mod("Scripts", scriptsDir, []);
    }
}

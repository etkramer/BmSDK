using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

[AttributeUsage(AttributeTargets.Class)]
public sealed class ScriptAttribute([CallerFilePath] string? name = null) : Attribute
{
    public string? Name { get; } = File.Exists(name) ? Path.GetFileName(name) : name;
}

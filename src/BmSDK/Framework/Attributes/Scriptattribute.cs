namespace BmSDK.Framework;

[AttributeUsage(AttributeTargets.Class)]
public sealed class ScriptAttribute(string? name = null) : Attribute
{
    public string? Name { get; } = name;
}

namespace BmSDK.Framework.Attributes;
[AttributeUsage(AttributeTargets.Class)]
public sealed class IntrinsicClassAttribute(string ClassPath) : Attribute
{
    public string ClassPath { get; } = ClassPath;
}
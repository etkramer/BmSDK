namespace BmSDK.Framework.T3D;

internal sealed class T3DProperty
{
    public required string Name { get; init; }
    public required string Value { get; init; }
}

internal sealed class T3DSubObject
{
    public required string ClassName { get; init; }
    public required string ObjectName { get; init; }
    public List<T3DProperty> Properties { get; } = [];
}

internal sealed class T3DActorDefinition
{
    public required string ClassName { get; init; }
    public required string ActorName { get; init; }
    public required string ObjectPath { get; init; }
    public List<T3DProperty> Properties { get; } = [];
    public List<T3DSubObject> SubObjects { get; } = [];
}

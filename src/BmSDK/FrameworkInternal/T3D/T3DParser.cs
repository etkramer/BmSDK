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

internal static class T3DParser
{
    public static T3DActorDefinition ParseFile(string filePath, string objectPath)
    {
        var text = File.ReadAllText(filePath);
        return Parse(text, objectPath);
    }

    public static T3DActorDefinition Parse(string text, string objectPath)
    {
        var lines = text.Split('\n')
            .Select(l => l.Trim())
            .Where(l => l.Length > 0 && !l.StartsWith("//"));

        T3DActorDefinition? actor = null;
        T3DSubObject? currentSubObject = null;

        foreach (var line in lines)
        {
            if (line.StartsWith("Begin Actor", StringComparison.OrdinalIgnoreCase))
            {
                var header = ParseHeader(line);
                actor = new T3DActorDefinition
                {
                    ClassName = header.GetValueOrDefault("Class", "Actor"),
                    ActorName = header.GetValueOrDefault("Name", Path.GetFileNameWithoutExtension(objectPath)),
                    ObjectPath = objectPath,
                };
            }
            else if (line.StartsWith("End Actor", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else if (line.StartsWith("Begin Object", StringComparison.OrdinalIgnoreCase))
            {
                var header = ParseHeader(line);
                currentSubObject = new T3DSubObject
                {
                    ClassName = header.GetValueOrDefault("Class", "Object"),
                    ObjectName = header.GetValueOrDefault("Name", ""),
                };
            }
            else if (line.StartsWith("End Object", StringComparison.OrdinalIgnoreCase))
            {
                if (currentSubObject is not null && actor is not null)
                {
                    actor.SubObjects.Add(currentSubObject);
                }
                currentSubObject = null;
            }
            else if (actor is not null)
            {
                var prop = ParsePropertyLine(line);
                if (prop is not null)
                {
                    if (currentSubObject is not null)
                    {
                        currentSubObject.Properties.Add(prop);
                    }
                    else
                    {
                        actor.Properties.Add(prop);
                    }
                }
            }
        }

        return actor ?? throw new FormatException($"No 'Begin Actor' found in T3D content for {objectPath}");
    }

    private static Dictionary<string, string> ParseHeader(string line)
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Skip "Begin Actor" or "Begin Object"
        for (int i = 2; i < parts.Length; i++)
        {
            var eqIndex = parts[i].IndexOf('=');
            if (eqIndex > 0)
            {
                var key = parts[i][..eqIndex];
                var value = parts[i][(eqIndex + 1)..];
                result[key] = value;
            }
        }

        return result;
    }

    private static T3DProperty? ParsePropertyLine(string line)
    {
        var eqIndex = line.IndexOf('=');
        if (eqIndex <= 0)
        {
            return null;
        }

        var name = line[..eqIndex].Trim();
        var value = line[(eqIndex + 1)..].Trim();
        return new T3DProperty { Name = name, Value = value };
    }

    internal static Dictionary<string, string> ParseStructLiteral(string value)
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        // Strip outer parens
        if (value.StartsWith('(') && value.EndsWith(')'))
        {
            value = value[1..^1];
        }

        // Split on commas, respecting nested parens
        int depth = 0;
        int start = 0;
        for (int i = 0; i <= value.Length; i++)
        {
            if (i == value.Length || (value[i] == ',' && depth == 0))
            {
                var segment = value[start..i].Trim();
                var eqIndex = segment.IndexOf('=');
                if (eqIndex > 0)
                {
                    var key = segment[..eqIndex].Trim();
                    var val = segment[(eqIndex + 1)..].Trim();
                    result[key] = val;
                }
                start = i + 1;
            }
            else if (value[i] == '(')
            {
                depth++;
            }
            else if (value[i] == ')')
            {
                depth--;
            }
        }

        return result;
    }
}

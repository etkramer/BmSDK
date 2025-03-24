using UELib.Core;

namespace BmSDK.Generator.Templates;

static class EnumTemplate
{
    public static FormattableString Render(UEnum enumObj)
    {
        var maxName = enumObj.Names.Last().ToString();
        var enumPrefix = maxName[..^4];

        return $$"""
            /// <summary>
            /// Enum: {{enumObj.Name}}
            /// </summary>
            public enum {{enumObj.ManagedName}}
            {
                {{enumObj.Names.SkipLast(1).Select(
                (name, i) => $"{GetItemManagedName(name, enumPrefix)} = {i},"
            )}}
            }
            """;
    }

    static string GetItemManagedName(string name, string prefix)
    {
        // Not all enums use the prefix convention
        if (!name.StartsWith(prefix))
        {
            return name;
        }

        // Skip the prefix part of the name
        var managedName = name[(prefix.Length + 1)..];

        // If removing this first part would cause it to start with a number, prepend an underscore
        if (!char.IsLetter(managedName[0]))
        {
            managedName = $"_{managedName}";
        }

        // Remove the prefix from the item name
        return managedName;
    }
}

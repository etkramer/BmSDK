using UELib.Core;

namespace BmSDK.Generator.Templates;

static class EnumTemplate
{
    public static FormattableString Render(UEnum enumObj) =>
        $$"""
            /// <summary>
            /// Enum: {{enumObj.Name}}
            /// </summary>
            public enum {{enumObj.ManagedName}}
            {
                {{enumObj.Names.Select((name, i) => $"{GetItemManagedName(name)} = {i},")}}
            }
            """;

    static string GetItemManagedName(string name)
    {
        // Break up name
        var nameParts = name.Split("_");
        if (nameParts.Length == 1)
        {
            return name;
        }

        // Skip the first part of the name
        var managedNameParts = nameParts.Skip(1);
        var managedName = string.Join("_", managedNameParts);

        // If removing this first part would cause it to start with a number, prepend an underscore
        if (!char.IsLetter(managedNameParts.First()[0]))
        {
            managedName = $"_{managedName}";
        }

        return managedName;
    }
}

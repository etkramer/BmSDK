using UELib.Core;

static class EnumTemplate
{
    public static FormattableString Render(UEnum enumObj) =>
        $$"""
            public enum {{enumObj.Name}}
            {
                {{enumObj.Names.Select((name, i) => $"{name} = {i},")}}
            }
            """;
}

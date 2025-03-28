namespace BmSDK;

public class Field : GameObject
{
    public static new Class StaticClass() =>
        _staticClass ??= StaticFindObjectChecked<Class>(null, null, "Core.Field", false);

    static Class? _staticClass = null;
}

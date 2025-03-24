namespace BmSDK;

public class Package : BaseObject
{
    public static new Class StaticClass() =>
        _staticClass ??= StaticFindObjectChecked<Class>(null, null, "Core.Package", false);

    static Class? _staticClass = null;

    // TODO
}

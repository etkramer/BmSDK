namespace BmSDK;

/// <summary>
/// Class: Class<br/>
/// (size = 0x200, offset = 0xE0)
/// </summary>
public unsafe sealed class Class : State
{
    public static new Class StaticClass() =>
        _staticClass ??= StaticFindObjectChecked<Class>(null, null, "Core.Class", false);

    static Class? _staticClass = null;
}

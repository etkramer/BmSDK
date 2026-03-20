#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MDmgType_LaughingGas<br/>
/// (flags = 0)
/// </summary>
public partial class MDmgType_LaughingGas : BmSDK.BmGame.RDmgType_SmokeBomb, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDmgType_LaughingGas", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MDmgType_LaughingGas() { }

    /// <summary>
    /// Constructs a new MDmgType_LaughingGas
    /// </summary>
    public MDmgType_LaughingGas(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MDmgType_LaughingGas Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDmgType_LaughingGas(nint ptr) : base(ptr) { }

}

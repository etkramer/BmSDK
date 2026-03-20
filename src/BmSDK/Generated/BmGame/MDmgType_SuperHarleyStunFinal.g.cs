#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MDmgType_SuperHarleyStunFinal<br/>
/// (size = 236)
/// (flags = 18)
/// </summary>
public partial class MDmgType_SuperHarleyStunFinal : BmSDK.BmGame.RDmgType_SuperStunFinal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDmgType_SuperHarleyStunFinal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MDmgType_SuperHarleyStunFinal() { }

    /// <summary>
    /// Constructs a new MDmgType_SuperHarleyStunFinal
    /// </summary>
    public MDmgType_SuperHarleyStunFinal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MDmgType_SuperHarleyStunFinal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDmgType_SuperHarleyStunFinal(nint ptr) : base(ptr) { }

}

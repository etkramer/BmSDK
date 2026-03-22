#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_ShockedStumble<br/>
/// (size = 140)
/// (flags = 18)
/// </summary>
public partial class RDmgType_ShockedStumble : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_ShockedStumble", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_ShockedStumble() { }

    /// <summary>
    /// Constructs a new RDmgType_ShockedStumble
    /// </summary>
    public RDmgType_ShockedStumble(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_ShockedStumble Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_ShockedStumble(nint ptr) : base(ptr) { }

}

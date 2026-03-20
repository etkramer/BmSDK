#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RDmgType_DiveBoostShockwave<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_DiveBoostShockwave : BmSDK.BmGame.RDmgType_HeavyStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RDmgType_DiveBoostShockwave", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_DiveBoostShockwave() { }

    /// <summary>
    /// Constructs a new RDmgType_DiveBoostShockwave
    /// </summary>
    public RDmgType_DiveBoostShockwave(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_DiveBoostShockwave Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_DiveBoostShockwave(nint ptr) : base(ptr) { }

}

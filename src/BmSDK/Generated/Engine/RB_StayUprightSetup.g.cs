#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_StayUprightSetup<br/>
/// (size = 260)
/// (flags = 134217874)
/// </summary>
public partial class RB_StayUprightSetup : BmSDK.Engine.RB_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_StayUprightSetup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_StayUprightSetup() { }

    /// <summary>
    /// Constructs a new RB_StayUprightSetup
    /// </summary>
    public RB_StayUprightSetup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_StayUprightSetup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_StayUprightSetup(nint ptr) : base(ptr) { }

}

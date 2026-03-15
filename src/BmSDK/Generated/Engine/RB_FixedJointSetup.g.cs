#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_FixedJointSetup<br/>
/// (size = 260)
/// (flags = 134217874)
/// </summary>
public partial class RB_FixedJointSetup : BmSDK.Engine.RB_BSJointSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_FixedJointSetup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_FixedJointSetup() { }

    /// <summary>
    /// Constructs a new RB_FixedJointSetup
    /// </summary>
    public RB_FixedJointSetup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_FixedJointSetup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_FixedJointSetup(nint ptr) : base(ptr) { }

}

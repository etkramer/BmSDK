#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_HarpoonDragBoat<br/>
/// (size = 364)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_HarpoonDragBoat : BmSDK.BmGame.RSpecialMoveConfig_HarpoonDragObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_HarpoonDragBoat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_HarpoonDragBoat() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_HarpoonDragBoat
    /// </summary>
    public RSpecialMoveConfig_HarpoonDragBoat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_HarpoonDragBoat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_HarpoonDragBoat(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ImpulseMultiplier
    /// </summary>
    public unsafe float ImpulseMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: PullSpeedFactor
    /// </summary>
    public unsafe float PullSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}

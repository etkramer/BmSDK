#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_Land<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_Land : BmSDK.BmGame.RSpecialMoveConfig_PoseTransition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_Land", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_Land() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_Land
    /// </summary>
    public RSpecialMoveConfig_Land(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_Land Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_Land(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ScreenShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bShakeScreen
    /// </summary>
    public unsafe bool bShakeScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bBowlingBallEffect
    /// </summary>
    public unsafe bool bBowlingBallEffect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: NoisyLand
    /// </summary>
    public unsafe bool NoisyLand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bAlignedMove
    /// </summary>
    public unsafe bool bAlignedMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: BowlingRadius
    /// </summary>
    public unsafe float BowlingRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: BowlingImpulse
    /// </summary>
    public unsafe float BowlingImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
}

#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSavedMove<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSavedMove : BmSDK.Engine.SavedMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSavedMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSavedMove() { }

    /// <summary>
    /// Constructs a new RSavedMove
    /// </summary>
    public RSavedMove(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSavedMove Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSavedMove(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: MoveVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MoveVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StructProperty: AimDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ByteProperty: MovementSpeed
    /// </summary>
    public unsafe byte MovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bStandingOffEdge
    /// </summary>
    public unsafe bool bStandingOffEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bStopPlayerFallingOffEdges
    /// </summary>
    public unsafe bool bStopPlayerFallingOffEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bHoldingRun
    /// </summary>
    public unsafe bool bHoldingRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }
}

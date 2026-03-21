#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2LengthUpdater<br/>
/// (size = 88)
/// (flags = 142610578)
/// </summary>
public partial class RRope2LengthUpdater : BmSDK.BmGame.RRope2Updater, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2LengthUpdater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2LengthUpdater() { }

    /// <summary>
    /// Constructs a new RRope2LengthUpdater
    /// </summary>
    public RRope2LengthUpdater(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2LengthUpdater Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2LengthUpdater(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: LengthChangeType
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2LengthUpdater.ELengthChangeType LengthChangeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2LengthUpdater.ELengthChangeType>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ByteProperty: LengthChangeEndType
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component.ERope2LengthChangeEndType LengthChangeEndType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component.ERope2LengthChangeEndType>(Ptr + 53); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 53); }
    }

    /// <summary>
    /// FloatProperty: FinalLength
    /// </summary>
    public unsafe float FinalLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// FloatProperty: FinalLengthChangeSpeed
    /// </summary>
    public unsafe float FinalLengthChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: InitialLengthChangeSpeed
    /// </summary>
    public unsafe float InitialLengthChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: DelayBeforeStartLengthChange
    /// </summary>
    public unsafe float DelayBeforeStartLengthChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: LengthChangeDuration
    /// </summary>
    public unsafe float LengthChangeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// FloatProperty: LengthChangeSpeed
    /// </summary>
    public unsafe float LengthChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// FloatProperty: InitialLength
    /// </summary>
    public unsafe float InitialLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// FloatProperty: RemainingChangeTime
    /// </summary>
    public unsafe float RemainingChangeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Enum: ELengthChangeType
    /// </summary>
    public enum ELengthChangeType
    {
        LENGTHCHANGETYPE_Speed = 0,
        LENGTHCHANGETYPE_Linear = 1,
        LENGTHCHANGETYPE_Smooth = 2,
        LENGTHCHANGETYPE_MAX = 3,
    }
}

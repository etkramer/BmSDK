#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2LengthUpdater<br/>
/// (size = 132)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2LengthUpdater.ELengthChangeType>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: LengthChangeEndType
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component.ERope2LengthChangeEndType LengthChangeEndType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component.ERope2LengthChangeEndType>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
    }

    /// <summary>
    /// FloatProperty: FinalLength
    /// </summary>
    public unsafe float FinalLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: FinalLengthChangeSpeed
    /// </summary>
    public unsafe float FinalLengthChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: InitialLengthChangeSpeed
    /// </summary>
    public unsafe float InitialLengthChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: DelayBeforeStartLengthChange
    /// </summary>
    public unsafe float DelayBeforeStartLengthChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: LengthChangeDuration
    /// </summary>
    public unsafe float LengthChangeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: LengthChangeSpeed
    /// </summary>
    public unsafe float LengthChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: InitialLength
    /// </summary>
    public unsafe float InitialLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: RemainingChangeTime
    /// </summary>
    public unsafe float RemainingChangeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
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

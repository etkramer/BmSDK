#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2AutoLengthUpdater<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRope2AutoLengthUpdater : BmSDK.BmGame.RRope2Updater, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2AutoLengthUpdater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2AutoLengthUpdater() { }

    /// <summary>
    /// Constructs a new RRope2AutoLengthUpdater
    /// </summary>
    public RRope2AutoLengthUpdater(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2AutoLengthUpdater Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2AutoLengthUpdater(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: LengthChangeEndType
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component.ERope2LengthChangeEndType LengthChangeEndType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component.ERope2LengthChangeEndType>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: MinAutoLength
    /// </summary>
    public unsafe float MinAutoLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: MaxAutoLength
    /// </summary>
    public unsafe float MaxAutoLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: AutoLengthMultiplier
    /// </summary>
    public unsafe float AutoLengthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: MaxLengthChangeSpeed
    /// </summary>
    public unsafe float MaxLengthChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}

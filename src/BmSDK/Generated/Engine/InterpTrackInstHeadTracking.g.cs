#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstHeadTracking<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackInstHeadTracking : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstHeadTracking", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstHeadTracking() { }

    /// <summary>
    /// Constructs a new InterpTrackInstHeadTracking
    /// </summary>
    public InterpTrackInstHeadTracking(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstHeadTracking Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstHeadTracking(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Action
    /// </summary>
    public unsafe byte Action
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// MapProperty: CurrentActorMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ CurrentActorMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ArrayProperty: TrackControls
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT TrackControls
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: LastUpdatePosition
    /// </summary>
    public unsafe float LastUpdatePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
}

#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2RenderUpdater<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRope2RenderUpdater : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2RenderUpdater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2RenderUpdater() { }

    /// <summary>
    /// Constructs a new RRope2RenderUpdater
    /// </summary>
    public RRope2RenderUpdater(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2RenderUpdater Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2RenderUpdater(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: RopeOwner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RopeOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bInitialised
    /// </summary>
    public unsafe bool bInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bNeedsRendererUpdate
    /// </summary>
    public unsafe bool bNeedsRendererUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bIncludeEndsBeforeRenderToEnd
    /// </summary>
    public unsafe bool bIncludeEndsBeforeRenderToEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bInludeEndsBeforeEndWithOffset
    /// </summary>
    public unsafe bool bInludeEndsBeforeEndWithOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: RopeRenderOrientation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeRenderOrientation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: RenderPoints
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RenderPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}

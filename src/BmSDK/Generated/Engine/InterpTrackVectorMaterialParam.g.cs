#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackVectorMaterialParam<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackVectorMaterialParam : BmSDK.Engine.InterpTrackVectorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackVectorMaterialParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackVectorMaterialParam() { }

    /// <summary>
    /// Constructs a new InterpTrackVectorMaterialParam
    /// </summary>
    public InterpTrackVectorMaterialParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackVectorMaterialParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackVectorMaterialParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: AllMaterialsOnThisActor
    /// </summary>
    public unsafe bool AllMaterialsOnThisActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 304); }
    }

    /// <summary>
    /// BoolProperty: bNeedsMaterialRefsUpdate
    /// </summary>
    public unsafe bool bNeedsMaterialRefsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 304); }
    }

    /// <summary>
    /// BoolProperty: ResetWhenMatineeExits
    /// </summary>
    public unsafe bool ResetWhenMatineeExits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 304); }
    }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrack.SubTracks> Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrack.SubTracks>>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ObjectProperty: Material
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Material
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// NameProperty: ParamName
    /// </summary>
    public unsafe BmSDK.FName ParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
}

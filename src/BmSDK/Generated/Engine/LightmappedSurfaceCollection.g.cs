#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LightmappedSurfaceCollection<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LightmappedSurfaceCollection : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LightmappedSurfaceCollection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LightmappedSurfaceCollection() { }

    /// <summary>
    /// Constructs a new LightmappedSurfaceCollection
    /// </summary>
    public LightmappedSurfaceCollection(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LightmappedSurfaceCollection Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LightmappedSurfaceCollection(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SourceModel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SourceModel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: Surfaces
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Surfaces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}

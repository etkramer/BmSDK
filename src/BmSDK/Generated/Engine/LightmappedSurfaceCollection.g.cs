#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LightmappedSurfaceCollection<br/>
/// (size = 60)
/// (flags = 134221970)
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
    public unsafe BmSDK.Engine.Model SourceModel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Model>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: Surfaces
    /// </summary>
    public unsafe BmSDK.TArray<int> Surfaces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }
}

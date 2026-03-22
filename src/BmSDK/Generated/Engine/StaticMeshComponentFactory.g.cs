#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: StaticMeshComponentFactory<br/>
/// (size = 68)
/// (flags = 134230162)
/// </summary>
public partial class StaticMeshComponentFactory : BmSDK.Engine.MeshComponentFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.StaticMeshComponentFactory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal StaticMeshComponentFactory() { }

    /// <summary>
    /// Constructs a new StaticMeshComponentFactory
    /// </summary>
    public StaticMeshComponentFactory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, StaticMeshComponentFactory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected StaticMeshComponentFactory(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: StaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh StaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }
}

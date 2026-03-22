#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryFracturedStaticMesh<br/>
/// (size = 108)
/// (flags = 134230166)
/// </summary>
public partial class ActorFactoryFracturedStaticMesh : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryFracturedStaticMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryFracturedStaticMesh() { }

    /// <summary>
    /// Constructs a new ActorFactoryFracturedStaticMesh
    /// </summary>
    public ActorFactoryFracturedStaticMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryFracturedStaticMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryFracturedStaticMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FracturedStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.FracturedStaticMesh FracturedStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FracturedStaticMesh>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: DrawScale3D
    /// </summary>
    public unsafe System.Numerics.Vector3 DrawScale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}

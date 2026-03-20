#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AutoNavMeshPathObstacleUnregister<br/>
/// (size = 100)
/// (flags = 0)
/// </summary>
public partial class AutoNavMeshPathObstacleUnregister : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AutoNavMeshPathObstacleUnregister", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AutoNavMeshPathObstacleUnregister() { }

    /// <summary>
    /// Constructs a new AutoNavMeshPathObstacleUnregister
    /// </summary>
    public AutoNavMeshPathObstacleUnregister(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AutoNavMeshPathObstacleUnregister Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AutoNavMeshPathObstacleUnregister(nint ptr) : base(ptr) { }

    /// <summary>
    /// InterfaceProperty: PathObstacleRef
    /// </summary>
    public unsafe BmSDK.Engine.Interface_NavMeshPathObstacle PathObstacleRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Interface_NavMeshPathObstacle>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}

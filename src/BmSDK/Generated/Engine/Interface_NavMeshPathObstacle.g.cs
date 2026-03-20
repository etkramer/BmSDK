#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Interface_NavMeshPathObstacle<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class Interface_NavMeshPathObstacle : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Interface_NavMeshPathObstacle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Interface_NavMeshPathObstacle() { }

    /// <summary>
    /// Constructs a new Interface_NavMeshPathObstacle
    /// </summary>
    public Interface_NavMeshPathObstacle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Interface_NavMeshPathObstacle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Interface_NavMeshPathObstacle(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObstacleActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor GetObstacleActor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.Interface_NavMeshPathObstacle.GetObstacleActor", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EEdgeHandlingStatus
    /// </summary>
    public enum EEdgeHandlingStatus
    {
        EHS_AddedBothDirs = 0,
        EHS_Added0to1 = 1,
        EHS_Added1to0 = 2,
        EHS_AddedNone = 3,
        EHS_MAX = 4,
    }
}

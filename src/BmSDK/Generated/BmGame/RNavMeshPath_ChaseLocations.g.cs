#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshPath_ChaseLocations<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RNavMeshPath_ChaseLocations : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavMeshPath_ChaseLocations", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavMeshPath_ChaseLocations() { }

    /// <summary>
    /// Constructs a new RNavMeshPath_ChaseLocations
    /// </summary>
    public RNavMeshPath_ChaseLocations(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavMeshPath_ChaseLocations Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshPath_ChaseLocations(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ChaseSearch
    /// </summary>
    public unsafe BmSDK.BmGame.RChaseLocationSearch ChaseSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChaseLocationSearch>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}

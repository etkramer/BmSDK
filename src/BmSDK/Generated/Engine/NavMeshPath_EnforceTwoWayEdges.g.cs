#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshPath_EnforceTwoWayEdges<br/>
/// (size = 108)
/// (flags = 0)
/// </summary>
public partial class NavMeshPath_EnforceTwoWayEdges : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshPath_EnforceTwoWayEdges", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshPath_EnforceTwoWayEdges() { }

    /// <summary>
    /// Constructs a new NavMeshPath_EnforceTwoWayEdges
    /// </summary>
    public NavMeshPath_EnforceTwoWayEdges(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshPath_EnforceTwoWayEdges Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshPath_EnforceTwoWayEdges(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: EnforceTwoWayEdges
    /// </summary>
    public unsafe static bool EnforceTwoWayEdges(BmSDK.Engine.NavigationHandle NavHandle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshPath_EnforceTwoWayEdges.EnforceTwoWayEdges", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }
}

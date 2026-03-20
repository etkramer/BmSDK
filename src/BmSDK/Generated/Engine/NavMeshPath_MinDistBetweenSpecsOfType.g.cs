#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshPath_MinDistBetweenSpecsOfType<br/>
/// (flags = 0)
/// </summary>
public partial class NavMeshPath_MinDistBetweenSpecsOfType : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshPath_MinDistBetweenSpecsOfType", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshPath_MinDistBetweenSpecsOfType() { }

    /// <summary>
    /// Constructs a new NavMeshPath_MinDistBetweenSpecsOfType
    /// </summary>
    public NavMeshPath_MinDistBetweenSpecsOfType(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshPath_MinDistBetweenSpecsOfType Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshPath_MinDistBetweenSpecsOfType(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Recycle
    /// </summary>
    public unsafe void Recycle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshPath_MinDistBetweenSpecsOfType.Recycle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnforceMinDist
    /// </summary>
    public unsafe static bool EnforceMinDist(BmSDK.Engine.NavigationHandle NavHandle, float InMinDist, BmSDK.Engine.Pylon.ENavMeshEdgeType InEdgeType, System.Numerics.Vector3 LastLocation = default, float InPenalty = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshPath_MinDistBetweenSpecsOfType.EnforceMinDist", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMinDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEdgeType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LastLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPenalty, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// FloatProperty: MinDistBetweenEdgeTypes
    /// </summary>
    public unsafe float MinDistBetweenEdgeTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: InitLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 InitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ByteProperty: EdgeType
    /// </summary>
    public unsafe BmSDK.Engine.Pylon.ENavMeshEdgeType EdgeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon.ENavMeshEdgeType>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: Penalty
    /// </summary>
    public unsafe float Penalty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
}

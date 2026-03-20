#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoalFilter_PolyEncompassesAI<br/>
/// (flags = 0)
/// </summary>
public partial class NavMeshGoalFilter_PolyEncompassesAI : BmSDK.Engine.NavMeshGoal_Filter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoalFilter_PolyEncompassesAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoalFilter_PolyEncompassesAI() { }

    /// <summary>
    /// Constructs a new NavMeshGoalFilter_PolyEncompassesAI
    /// </summary>
    public NavMeshGoalFilter_PolyEncompassesAI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoalFilter_PolyEncompassesAI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoalFilter_PolyEncompassesAI(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: MakeSureAIFits
    /// </summary>
    public unsafe static bool MakeSureAIFits(BmSDK.Engine.NavMeshGoal_GenericFilterContainer FilterContainer, System.Numerics.Vector3 InOverrideExtentToCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshGoalFilter_PolyEncompassesAI.MakeSureAIFits", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterContainer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InOverrideExtentToCheck, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// StructProperty: OverrideExtentToCheck
    /// </summary>
    public unsafe System.Numerics.Vector3 OverrideExtentToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}

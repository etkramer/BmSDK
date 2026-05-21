#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoalFilter_OutSideOfDotProductWedge<br/>
/// (size = 124)
/// (flags = 134217874)
/// </summary>
public partial class NavMeshGoalFilter_OutSideOfDotProductWedge : BmSDK.Engine.NavMeshGoal_Filter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoalFilter_OutSideOfDotProductWedge", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as NavMeshGoalFilter_OutSideOfDotProductWedge.
    /// </summary>
    public static NavMeshGoalFilter_OutSideOfDotProductWedge DefaultObject => (NavMeshGoalFilter_OutSideOfDotProductWedge)StaticClass().DefaultObject;

    internal NavMeshGoalFilter_OutSideOfDotProductWedge() { }

    /// <summary>
    /// Constructs a new NavMeshGoalFilter_OutSideOfDotProductWedge
    /// </summary>
    public NavMeshGoalFilter_OutSideOfDotProductWedge(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoalFilter_OutSideOfDotProductWedge Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoalFilter_OutSideOfDotProductWedge(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavMeshGoalFilter_OutSideOfDotProductWedge>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshGoalFilter_OutSideOfDotProductWedge>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavMeshGoalFilter_OutSideOfDotProductWedge>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshGoalFilter_OutSideOfDotProductWedge>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshGoalFilter_OutSideOfDotProductWedge>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshGoalFilter_OutSideOfDotProductWedge>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavMeshGoalFilter_OutSideOfDotProductWedge>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshGoalFilter_OutSideOfDotProductWedge>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: OutsideOfDotProductWedge
    /// </summary>
    public unsafe static bool OutsideOfDotProductWedge(BmSDK.Engine.NavMeshGoal_GenericFilterContainer FilterContainer, System.Numerics.Vector3 InLocation, BmSDK.Rotator InRotation, float InEpsilon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshGoalFilter_OutSideOfDotProductWedge.OutsideOfDotProductWedge", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterContainer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEpsilon, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Location
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 96);

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Rotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 108);

    /// <summary>
    /// FloatProperty: Epsilon
    /// </summary>
    public unsafe float Epsilon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
}

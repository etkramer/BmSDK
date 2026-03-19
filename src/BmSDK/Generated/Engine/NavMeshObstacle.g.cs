#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshObstacle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavMeshObstacle : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshObstacle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshObstacle() { }

    /// <summary>
    /// Constructs a new NavMeshObstacle
    /// </summary>
    public NavMeshObstacle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshObstacle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshObstacle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavMeshObstacle>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshObstacle>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavMeshObstacle>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshObstacle>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshObstacle>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavMeshObstacle>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavMeshObstacle>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 676); }
    }

    /// <summary>
    /// BoolProperty: bPreserveInternalGeo
    /// </summary>
    public unsafe bool bPreserveInternalGeo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 676); }
    }

    /// <summary>
    /// BoolProperty: bDoneFloorCheck
    /// </summary>
    public unsafe bool bDoneFloorCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 676); }
    }

    /// <summary>
    /// BoolProperty: bSnapToGround
    /// </summary>
    public unsafe bool bSnapToGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 676); }
    }

    /// <summary>
    /// StructProperty: BaseLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BaseLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }
}

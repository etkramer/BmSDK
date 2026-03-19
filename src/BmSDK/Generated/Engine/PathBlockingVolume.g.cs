#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PathBlockingVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class PathBlockingVolume : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PathBlockingVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PathBlockingVolume() { }

    /// <summary>
    /// Constructs a new PathBlockingVolume
    /// </summary>
    public PathBlockingVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PathBlockingVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PathBlockingVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PathBlockingVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PathBlockingVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PathBlockingVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PathBlockingVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PathBlockingVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<PathBlockingVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<PathBlockingVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: AssociatedActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AssociatedActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: PhysicalMaterialOverrideForCollisionComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysicalMaterialOverrideForCollisionComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bForcePawnWalk
    /// </summary>
    public unsafe bool bForcePawnWalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bProcessAllActors
    /// </summary>
    public unsafe bool bProcessAllActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bOnlyCollideWithPlayer
    /// </summary>
    public unsafe bool bOnlyCollideWithPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bNoWallPlant
    /// </summary>
    public unsafe bool bNoWallPlant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bPawnsOnly
    /// </summary>
    public unsafe bool bPawnsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 732); }
    }

    /// <summary>
    /// IntProperty: PinGcRefCount
    /// </summary>
    public unsafe int PinGcRefCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }
}

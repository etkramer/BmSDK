#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LadderVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LadderVolume : BmSDK.Engine.PhysicsVolume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LadderVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LadderVolume() { }

    /// <summary>
    /// Constructs a new LadderVolume
    /// </summary>
    public LadderVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LadderVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LadderVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LadderVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LadderVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LadderVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LadderVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LadderVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LadderVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LadderVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: WallDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WallDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// StructProperty: LookDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LookDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// StructProperty: ClimbDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ClimbDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: LadderList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LadderList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: PendingClimber
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PendingClimber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ComponentProperty: WallDirArrow
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WallDirArrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bNoPhysicalLadder
    /// </summary>
    public unsafe bool bNoPhysicalLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: bAutoPath
    /// </summary>
    public unsafe bool bAutoPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: bAllowLadderStrafing
    /// </summary>
    public unsafe bool bAllowLadderStrafing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }
}

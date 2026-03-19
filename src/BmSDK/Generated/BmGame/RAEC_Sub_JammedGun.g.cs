#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Sub_JammedGun<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAEC_Sub_JammedGun : BmSDK.BmGame.RAlertEventCoordinatorSolo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Sub_JammedGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAEC_Sub_JammedGun() { }

    /// <summary>
    /// Constructs a new RAEC_Sub_JammedGun
    /// </summary>
    public RAEC_Sub_JammedGun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAEC_Sub_JammedGun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Sub_JammedGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Sub_JammedGun>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Sub_JammedGun>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Sub_JammedGun>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Sub_JammedGun>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Sub_JammedGun>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Sub_JammedGun>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Sub_JammedGun>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: HostCon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HostCon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: Parent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Parent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bExpandDebug
    /// </summary>
    public unsafe bool bExpandDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bExtraAware
    /// </summary>
    public unsafe bool bExtraAware
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bAllowApproximateVisionChecks
    /// </summary>
    public unsafe bool bAllowApproximateVisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bCanSeePlayerOverEdge
    /// </summary>
    public unsafe bool bCanSeePlayerOverEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bCanSeePlayerThroughPartialObstruction
    /// </summary>
    public unsafe bool bCanSeePlayerThroughPartialObstruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bFiresPlayerSeenKismet
    /// </summary>
    public unsafe bool bFiresPlayerSeenKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bVisionCheckSmokeFailFudge
    /// </summary>
    public unsafe bool bVisionCheckSmokeFailFudge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bCanStasis
    /// </summary>
    public unsafe bool bCanStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bBeginShutdownCalled
    /// </summary>
    public unsafe bool bBeginShutdownCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }
}

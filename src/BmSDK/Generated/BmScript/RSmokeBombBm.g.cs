#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSmokeBombBm<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSmokeBombBm : BmSDK.BmGame.RSmokeBomb, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSmokeBombBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSmokeBombBm() { }

    /// <summary>
    /// Constructs a new RSmokeBombBm
    /// </summary>
    public RSmokeBombBm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSmokeBombBm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSmokeBombBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmokeBombBm>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBombBm>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmokeBombBm>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBombBm>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBombBm>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmokeBombBm>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmokeBombBm>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: SmokeBombGrappleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmokeBombGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: SmokeBombStandingMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmokeBombStandingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: SmokeBombCoverMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmokeBombCoverMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: SmokeScreenArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmokeScreenArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// BoolProperty: bCanToggleDetectiveMode
    /// </summary>
    public unsafe bool bCanToggleDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2624); }
    }

    /// <summary>
    /// BoolProperty: bHasTurnedOnDetectiveMode
    /// </summary>
    public unsafe bool bHasTurnedOnDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2624); }
    }
}

#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBatarangBm<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatarangBm : BmSDK.BmGame.RBatarang, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBatarangBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatarangBm() { }

    /// <summary>
    /// Constructs a new RBatarangBm
    /// </summary>
    public RBatarangBm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatarangBm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatarangBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangBm>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangBm>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangBm>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangBm>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangBm>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangBm>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangBm>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: CatchBatarangMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangGargoyleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangGargoyleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangRailingMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangWireMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangWireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangCoverMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangCoverMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: ElectrifiedCatchAudio
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectrifiedCatchAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// ClassProperty: RCBatarangProjectileClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RCBatarangProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ComponentProperty: ElectrifiedCatchParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectrifiedCatchParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// BoolProperty: bCanUseMultiBatarang
    /// </summary>
    public unsafe bool bCanUseMultiBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2704) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2704); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2704); }
    }
}

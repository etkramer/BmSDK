#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGlideOutOfBoundsVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGlideOutOfBoundsVolume : BmSDK.Engine.BlockingVolume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGlideOutOfBoundsVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGlideOutOfBoundsVolume() { }

    /// <summary>
    /// Constructs a new RGlideOutOfBoundsVolume
    /// </summary>
    public RGlideOutOfBoundsVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGlideOutOfBoundsVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGlideOutOfBoundsVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGlideOutOfBoundsVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGlideOutOfBoundsVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGlideOutOfBoundsVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGlideOutOfBoundsVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGlideOutOfBoundsVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGlideOutOfBoundsVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGlideOutOfBoundsVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: TurnAroundMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurnAroundMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: TurnAroundSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurnAroundSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: PlayGunfireFX
    /// </summary>
    public unsafe bool PlayGunfireFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: GunFireTimer
    /// </summary>
    public unsafe float GunFireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: PreviousGunFireTimer
    /// </summary>
    public unsafe float PreviousGunFireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// StructProperty: ImpactLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ImpactLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StructProperty: ImpactRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ImpactRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: GunFireEffects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> GunFireEffects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
}

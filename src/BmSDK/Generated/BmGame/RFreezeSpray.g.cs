#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFreezeSpray<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFreezeSpray : BmSDK.BmGame.RProjectileGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFreezeSpray", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFreezeSpray() { }

    /// <summary>
    /// Constructs a new RFreezeSpray
    /// </summary>
    public RFreezeSpray(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFreezeSpray Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFreezeSpray(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeSpray>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeSpray>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeSpray>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeSpray>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeSpray>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeSpray>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeSpray>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ThrowSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThrowSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: IceExplodeEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT IceExplodeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: GroundBlastParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GroundBlastParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: SpawnSecondaryProjectileArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnSecondaryProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ClassProperty: SpawnSecondaryProjectileClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnSecondaryProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// ArrayProperty: FrozenVillains
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>>> FrozenVillains
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>>>>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// ArrayProperty: PendingProjectiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>> PendingProjectiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>>>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ArrayProperty: ProximityProjectiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>> ProximityProjectiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// ArrayProperty: ClusterTraps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText> ClusterTraps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// BoolProperty: bPlayerHasFreezeGrenadeProximityUpgrade
    /// </summary>
    public unsafe bool bPlayerHasFreezeGrenadeProximityUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2696); }
    }

    /// <summary>
    /// BoolProperty: bPlayerHasFreezeDurationUpgrade
    /// </summary>
    public unsafe bool bPlayerHasFreezeDurationUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2696); }
    }

    /// <summary>
    /// BoolProperty: bPlayerHasFreezeClusterUpgrade
    /// </summary>
    public unsafe bool bPlayerHasFreezeClusterUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2696); }
    }

    /// <summary>
    /// BoolProperty: bPlayerHasFreezeClusterProximityUpgrade
    /// </summary>
    public unsafe bool bPlayerHasFreezeClusterProximityUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2696); }
    }

    /// <summary>
    /// FloatProperty: fFreezeClusterBlastRadius
    /// </summary>
    public unsafe float fFreezeClusterBlastRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }
}

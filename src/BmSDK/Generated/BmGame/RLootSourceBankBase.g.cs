#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RLootSourceBankBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RLootSourceBankBase : BmSDK.BmGame.RLootSourceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RLootSourceBankBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RLootSourceBankBase() { }

    /// <summary>
    /// Constructs a new RLootSourceBankBase
    /// </summary>
    public RLootSourceBankBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RLootSourceBankBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLootSourceBankBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLootSourceBankBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLootSourceBankBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLootSourceBankBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLootSourceBankBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLootSourceBankBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLootSourceBankBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLootSourceBankBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ClassProperty: lootBagClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT lootBagClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// IntProperty: lootValue
    /// </summary>
    public unsafe int lootValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// IntProperty: numUses
    /// </summary>
    public unsafe int numUses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// IntProperty: numUsesRemaining
    /// </summary>
    public unsafe int numUsesRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: Priority
    /// </summary>
    public unsafe float Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: hardLockingPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT hardLockingPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: lootExhaustedXrayMat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT lootExhaustedXrayMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ObjectProperty: lootNotExhaustedXrayMat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT lootNotExhaustedXrayMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplosionVFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JammedExplosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExplodeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: ActiveCarriedObject
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActiveCarriedObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ComponentProperty: SecondaryMeshComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SecondaryMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ArrayProperty: softLockingPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> softLockingPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// IntProperty: lootSourceGroup
    /// </summary>
    public unsafe int lootSourceGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bInitialStateChangeTakenPlace
    /// </summary>
    public unsafe bool bInitialStateChangeTakenPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bMainStateChangeTakenPlace
    /// </summary>
    public unsafe bool bMainStateChangeTakenPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bCheckedForDialogueLocation
    /// </summary>
    public unsafe bool bCheckedForDialogueLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: lootSourceEnabled
    /// </summary>
    public unsafe bool lootSourceEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bHighlightInDetectiveMode
    /// </summary>
    public unsafe bool bHighlightInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bIsAnAssignedSentryGun
    /// </summary>
    public unsafe bool bIsAnAssignedSentryGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bCanAutoSelect
    /// </summary>
    public unsafe bool bCanAutoSelect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bHasPlayedAnyAnim
    /// </summary>
    public unsafe bool bHasPlayedAnyAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// NameProperty: meshAnim_Cocky
    /// </summary>
    public unsafe BmSDK.FName meshAnim_Cocky
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// NameProperty: meshAnim_Nervous
    /// </summary>
    public unsafe BmSDK.FName meshAnim_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// NameProperty: bagPickedUpAnimName
    /// </summary>
    public unsafe BmSDK.FName bagPickedUpAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: bagPickedUpAnimStartTime
    /// </summary>
    public unsafe float bagPickedUpAnimStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: approxTargetLocationOffset
    /// </summary>
    public unsafe float approxTargetLocationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// NameProperty: DialogueLocationName
    /// </summary>
    public unsafe BmSDK.FName DialogueLocationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: lootingDuration
    /// </summary>
    public unsafe float lootingDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: lootingDuration_COCKY
    /// </summary>
    public unsafe float lootingDuration_COCKY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: lootingTimeRemaining
    /// </summary>
    public unsafe float lootingTimeRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
}

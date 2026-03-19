#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainMultiStageBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnVillainMultiStageBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainMultiStageBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainMultiStageBase() { }

    /// <summary>
    /// Constructs a new RPawnVillainMultiStageBase
    /// </summary>
    public RPawnVillainMultiStageBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainMultiStageBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainMultiStageBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStageBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: FistFxCompLeft
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FistFxCompLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6664); }
    }

    /// <summary>
    /// ComponentProperty: FistFxCompRight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FistFxCompRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6672); }
    }

    /// <summary>
    /// ObjectProperty: FistFx
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FistFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }

    /// <summary>
    /// ObjectProperty: BladeFx
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BladeFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6688); }
    }

    /// <summary>
    /// ObjectProperty: EFAudible
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC EFAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// ObjectProperty: EFistLoopingEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EFistLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// ObjectProperty: LastFoundThugToThrow
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastFoundThugToThrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6712); }
    }

    /// <summary>
    /// ObjectProperty: WeaponXrayMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainMultiStageBase.AllowedStates WeaponXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainMultiStageBase.AllowedStates>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// ComponentProperty: BladeFxCompRight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BladeFxCompRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// ComponentProperty: BladeFxCompLeft
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BladeFxCompLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastWeaponChange
    /// </summary>
    public unsafe float TimeSinceLastWeaponChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6744); }
    }

    /// <summary>
    /// BoolProperty: bFistFxOn
    /// </summary>
    public unsafe bool bFistFxOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bLeftBladeFxOn
    /// </summary>
    public unsafe bool bLeftBladeFxOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bRightBladeFxOn
    /// </summary>
    public unsafe bool bRightBladeFxOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bQueueChangeState
    /// </summary>
    public unsafe bool bQueueChangeState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bInvincible
    /// </summary>
    public unsafe bool bInvincible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// BoolProperty: bTutorial
    /// </summary>
    public unsafe bool bTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6748); }
    }

    /// <summary>
    /// IntProperty: NumTimesHit
    /// </summary>
    public unsafe int NumTimesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// IntProperty: MaxHits
    /// </summary>
    public unsafe int MaxHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }

    /// <summary>
    /// ByteProperty: ThugState
    /// </summary>
    public unsafe byte ThugState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// ArrayProperty: AllowedStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>> AllowedStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }

    /// <summary>
    /// ArrayProperty: TempThugStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> TempThugStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }

    /// <summary>
    /// IntProperty: NumStrikes
    /// </summary>
    public unsafe int NumStrikes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }
}

#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnJokerHallucination<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnJokerHallucination : BmSDK.BmGame.RPawnFriendly, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnJokerHallucination", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnJokerHallucination() { }

    /// <summary>
    /// Constructs a new RPawnJokerHallucination
    /// </summary>
    public RPawnJokerHallucination(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnJokerHallucination Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnJokerHallucination(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bShouldFadeIn
    /// </summary>
    public unsafe bool bShouldFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bShouldFadeInSet
    /// </summary>
    public unsafe bool bShouldFadeInSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadeInWhenOffScreen
    /// </summary>
    public unsafe bool bFadeInWhenOffScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadingOut
    /// </summary>
    public unsafe bool bFadingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutInstant
    /// </summary>
    public unsafe bool bFadeOutInstant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToFadeOut
    /// </summary>
    public unsafe bool bWaitingToFadeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadeWhenNotInTransition
    /// </summary>
    public unsafe bool bFadeWhenNotInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bInSyncWalk
    /// </summary>
    public unsafe bool bInSyncWalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bAutoFadeIfBatmanTouches
    /// </summary>
    public unsafe bool bAutoFadeIfBatmanTouches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bDontDeleteOnFade
    /// </summary>
    public unsafe bool bDontDeleteOnFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadeOnCarWarning
    /// </summary>
    public unsafe bool bFadeOnCarWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bDrawSphere
    /// </summary>
    public unsafe bool bDrawSphere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// ObjectProperty: JokerDefine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JokerDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4744); }
    }

    /// <summary>
    /// ObjectProperty: JokerDefineNoApex
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JokerDefineNoApex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4752); }
    }

    /// <summary>
    /// ObjectProperty: SavedWalkNPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SavedWalkNPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }

    /// <summary>
    /// ObjectProperty: CombatIncidentalActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatIncidentalActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4768); }
    }

    /// <summary>
    /// ObjectProperty: SafeThug
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SafeThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4776); }
    }

    /// <summary>
    /// ObjectProperty: Camera
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Camera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4784); }
    }

    /// <summary>
    /// ClassProperty: JokerCharacter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JokerCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4792); }
    }

    /// <summary>
    /// StrProperty: CaseIdentifier
    /// </summary>
    public unsafe BmSDK.FString CaseIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// NameProperty: WalkSyncAnimName
    /// </summary>
    public unsafe BmSDK.FName WalkSyncAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// FloatProperty: FadeSpeedMultiplier
    /// </summary>
    public unsafe float FadeSpeedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// ByteProperty: CurrentCombatQuality
    /// </summary>
    public unsafe byte CurrentCombatQuality
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ByteProperty: InterceptHallucinationType
    /// </summary>
    public unsafe byte InterceptHallucinationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4829); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4829); }
    }

    /// <summary>
    /// FloatProperty: JokerSpawnTime
    /// </summary>
    public unsafe float JokerSpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// IntProperty: FramesOffScreen
    /// </summary>
    public unsafe int FramesOffScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// Enum: CombatQualityType
    /// </summary>
    public enum CombatQualityType
    {
        CQT_Lame = 0,
        CQT_Excellent = 1,
        CQT_Neutral = 2,
        CQT_MAX = 3,
    }

    /// <summary>
    /// Enum: TypesOfHallucination
    /// </summary>
    public enum TypesOfHallucination
    {
        JokerHallucination_Misc = 0,
        JokerHallucination_HidePoint = 1,
        JokerHallucination_CombatTakedown = 2,
        JokerHallucination_CombatFinalBlow = 3,
        JokerHallucination_InvertedTakedown = 4,
        JokerHallucination_PredatorTakedown = 5,
        JokerHallucination_WalkWithThug = 6,
        JokerHallucination_SpecialMove = 7,
        JokerHallucination_TeasePredThug = 8,
        JokerHallucination_TeaseCombatThug = 9,
        JokerHallucination_GrenadeGrate = 10,
        JokerHallucination_ManDown = 11,
        JokerHallucination_Sequence = 12,
        JokerHallucination_NumHallucinationTypes = 13,
        JokerHallucination_MAX = 14,
    }
}

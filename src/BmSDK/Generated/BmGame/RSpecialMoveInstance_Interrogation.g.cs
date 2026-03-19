#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_Interrogation<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveInstance_Interrogation : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_Interrogation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveInstance_Interrogation() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_Interrogation
    /// </summary>
    public RSpecialMoveInstance_Interrogation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveInstance_Interrogation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_Interrogation(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_Interrogation>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_Interrogation>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_Interrogation>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_Interrogation>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_Interrogation>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_Interrogation>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_Interrogation>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Victim
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Victim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: VictimController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VictimController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: ControlledBehaviour
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ControlledBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: Conversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Conversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: HangRope
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HangRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: VictimStartAnimSetOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VictimStartAnimSetOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// BoolProperty: bMirrored
    /// </summary>
    public unsafe bool bMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bConversationFound
    /// </summary>
    public unsafe bool bConversationFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bCanPlayConversation
    /// </summary>
    public unsafe bool bCanPlayConversation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bConversationPlaying
    /// </summary>
    public unsafe bool bConversationPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bPlayingCamTransition
    /// </summary>
    public unsafe bool bPlayingCamTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: AttachRope
    /// </summary>
    public unsafe bool AttachRope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bAttachRopeToFeet
    /// </summary>
    public unsafe bool bAttachRopeToFeet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bDebugConversation
    /// </summary>
    public unsafe bool bDebugConversation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bDebugCollision
    /// </summary>
    public unsafe bool bDebugCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bDontKOVictim
    /// </summary>
    public unsafe bool bDontKOVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bFinishedVictim
    /// </summary>
    public unsafe bool bFinishedVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bDontMirror
    /// </summary>
    public unsafe bool bDontMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bAlreadyUnlockedSecrets
    /// </summary>
    public unsafe bool bAlreadyUnlockedSecrets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bDebugSimulateOverworld
    /// </summary>
    public unsafe bool bDebugSimulateOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bCalculateInitialFallbackPos
    /// </summary>
    public unsafe bool bCalculateInitialFallbackPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bDebugConversationActivated
    /// </summary>
    public unsafe bool bDebugConversationActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bThugCanAttack
    /// </summary>
    public unsafe bool bThugCanAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bThugInAttack
    /// </summary>
    public unsafe bool bThugInAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bBatmanFinishedCounter
    /// </summary>
    public unsafe bool bBatmanFinishedCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bCounterActive
    /// </summary>
    public unsafe bool bCounterActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bThugAttackedAndHit
    /// </summary>
    public unsafe bool bThugAttackedAndHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneFirstTrans
    /// </summary>
    public unsafe bool bHasDoneFirstTrans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraDueToNoOptions
    /// </summary>
    public unsafe bool bDisableCameraDueToNoOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// StructProperty: ReferenceLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReferenceLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StructProperty: ReferenceRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReferenceRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// StructProperty: Transition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Transition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: VictimTransition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VictimTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// StrProperty: LoadingPackageName
    /// </summary>
    public unsafe BmSDK.FString LoadingPackageName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// StrProperty: LoadingConversationName
    /// </summary>
    public unsafe BmSDK.FString LoadingConversationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: InitialLocator
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitialLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// StructProperty: AnimatedCameraCollisionOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AnimatedCameraCollisionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StructProperty: CatwomanCameraCollisionOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CatwomanCameraCollisionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: IntimidateAnimIndex
    /// </summary>
    public unsafe int IntimidateAnimIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// StrProperty: FFXInterrogationName
    /// </summary>
    public unsafe BmSDK.FString FFXInterrogationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: FFXInterrogationStrength
    /// </summary>
    public unsafe float FFXInterrogationStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// StrProperty: FFXIntimidationName
    /// </summary>
    public unsafe BmSDK.FString FFXIntimidationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// FloatProperty: FFXIntimidationStrength
    /// </summary>
    public unsafe float FFXIntimidationStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// StrProperty: FFXPlayerIntimidationName
    /// </summary>
    public unsafe BmSDK.FString FFXPlayerIntimidationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: FFXPlayerIntimidationStrength
    /// </summary>
    public unsafe float FFXPlayerIntimidationStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// FloatProperty: FFXBlendTime
    /// </summary>
    public unsafe float FFXBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// ByteProperty: ThugReactionType
    /// </summary>
    public unsafe byte ThugReactionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// StructProperty: RopeAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// StructProperty: RopeRenderAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeRenderAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// FloatProperty: RopeLength
    /// </summary>
    public unsafe float RopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// NameProperty: RopeBoneAttachName
    /// </summary>
    public unsafe BmSDK.FName RopeBoneAttachName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: RopeAttachConnectionDistance
    /// </summary>
    public unsafe float RopeAttachConnectionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// StructProperty: RopePelvisAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopePelvisAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// ArrayProperty: RopeExtraAttachConnections
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> RopeExtraAttachConnections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// StructProperty: RopeRenderStartOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeRenderStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// StructProperty: RopePhysStartOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopePhysStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// IntProperty: RandomCameraIndex
    /// </summary>
    public unsafe int RandomCameraIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// IntProperty: NumRandomCameras
    /// </summary>
    public unsafe int NumRandomCameras
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// NameProperty: VictimStartAnimOverride
    /// </summary>
    public unsafe BmSDK.FName VictimStartAnimOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// IntProperty: LineCounter
    /// </summary>
    public unsafe int LineCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// ArrayProperty: SecretLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> SecretLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// StructProperty: LastLocatorFallbackPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastLocatorFallbackPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfAttack
    /// </summary>
    public unsafe float ChanceOfAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }
}

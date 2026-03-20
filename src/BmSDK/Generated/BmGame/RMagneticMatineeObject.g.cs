#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMagneticMatineeObject<br/>
/// (flags = 0)
/// </summary>
public partial class RMagneticMatineeObject : BmSDK.Engine.InterpActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMagneticMatineeObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMagneticMatineeObject() { }

    /// <summary>
    /// Constructs a new RMagneticMatineeObject
    /// </summary>
    public RMagneticMatineeObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMagneticMatineeObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticMatineeObject(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticMatineeObject>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticMatineeObject>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticMatineeObject>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticMatineeObject>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticMatineeObject>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticMatineeObject>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticMatineeObject>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bInfluencedByREC
    /// </summary>
    public unsafe bool bInfluencedByREC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bBrakes
    /// </summary>
    public unsafe bool bBrakes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bOnlyReactToMagneticSurface
    /// </summary>
    public unsafe bool bOnlyReactToMagneticSurface
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bMatineeEventDataIsValid
    /// </summary>
    public unsafe bool bMatineeEventDataIsValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bFirstFrameDone
    /// </summary>
    public unsafe bool bFirstFrameDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: StopLoopOnSlowdown
    /// </summary>
    public unsafe bool StopLoopOnSlowdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: AudioStarted
    /// </summary>
    public unsafe bool AudioStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: AudioAllowStart
    /// </summary>
    public unsafe bool AudioAllowStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: AudioDirectionReachedPeak
    /// </summary>
    public unsafe bool AudioDirectionReachedPeak
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bJammed
    /// </summary>
    public unsafe bool bJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: AutoSaveMatineePos
    /// </summary>
    public unsafe bool AutoSaveMatineePos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: RestoreSavedMatineePos
    /// </summary>
    public unsafe bool RestoreSavedMatineePos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: Gravity
    /// </summary>
    public unsafe System.Numerics.Vector3 Gravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// StructProperty: SpringPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 SpringPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: SpringLength
    /// </summary>
    public unsafe float SpringLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: SpringStrength
    /// </summary>
    public unsafe float SpringStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: MaxSpringForce
    /// </summary>
    public unsafe float MaxSpringForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: MinSpringForce
    /// </summary>
    public unsafe float MinSpringForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: SpringDamping
    /// </summary>
    public unsafe float SpringDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// StructProperty: ForwardMovementProperties
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticMatineeObject.FMagneticMatineeMovementProperties ForwardMovementProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticMatineeObject.FMagneticMatineeMovementProperties>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// StructProperty: BackwardMovementProperties
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticMatineeObject.FMagneticMatineeMovementProperties BackwardMovementProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticMatineeObject.FMagneticMatineeMovementProperties>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// NameProperty: InitialPositionMatineeEventName
    /// </summary>
    public unsafe BmSDK.FName InitialPositionMatineeEventName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// NameProperty: StopPositionMatineeEventName
    /// </summary>
    public unsafe BmSDK.FName StopPositionMatineeEventName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// NameProperty: SpringPositionMatineeEventName
    /// </summary>
    public unsafe BmSDK.FName SpringPositionMatineeEventName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: AffectedParticleEmitterDatas
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMagneticMatineeObject.FMagMatObjEmitterData> AffectedParticleEmitterDatas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticMatineeObject.FMagMatObjEmitterData>>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ObjectProperty: Matinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp Matinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: CachedInterpData
    /// </summary>
    public unsafe BmSDK.Engine.InterpData CachedInterpData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpData>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: SpeedAudioParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName SpeedAudioParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: LoopingEventForMatinee
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LoopingEventForMatinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: EventToPlayOnMin
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EventToPlayOnMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: EventToPlayOnMax
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent EventToPlayOnMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: CurrentMatineeSpeed
    /// </summary>
    public unsafe float CurrentMatineeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// StructProperty: CurrentMagForce
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentMagForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: InitialMatineePosition
    /// </summary>
    public unsafe float InitialMatineePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ArrayProperty: StopPositions
    /// </summary>
    public unsafe BmSDK.TArray<float> StopPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ArrayProperty: CalculatedVelocities
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMagneticMatineeObject.FMagMatObjCalculatedVelocity> CalculatedVelocities
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticMatineeObject.FMagMatObjCalculatedVelocity>>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: DirectionTestDeltaTime
    /// </summary>
    public unsafe float DirectionTestDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: LastMagStr
    /// </summary>
    public unsafe float LastMagStr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// StructProperty: LastSpeed
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// StructProperty: Speed
    /// </summary>
    public unsafe System.Numerics.Vector3 Speed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: NormalisedSpeed
    /// </summary>
    public unsafe float NormalisedSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// StrProperty: LastState
    /// </summary>
    public unsafe BmSDK.FString LastState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// StructProperty: Direction
    /// </summary>
    public unsafe System.Numerics.Vector3 Direction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// FloatProperty: MaxPosSpeed
    /// </summary>
    public unsafe float MaxPosSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// FloatProperty: MaxNegSpeed
    /// </summary>
    public unsafe float MaxNegSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// FloatProperty: StartSpeed
    /// </summary>
    public unsafe float StartSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// FloatProperty: StopSpeed
    /// </summary>
    public unsafe float StopSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: MinBumpSpeed
    /// </summary>
    public unsafe float MinBumpSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: OptionalVelocityToStopLoopRising
    /// </summary>
    public unsafe float OptionalVelocityToStopLoopRising
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: OptionalVelocityToStopLoopFalling
    /// </summary>
    public unsafe float OptionalVelocityToStopLoopFalling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// FloatProperty: AudioRestartSpeed
    /// </summary>
    public unsafe float AudioRestartSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ByteProperty: AudioDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticMatineeObject.MagAudioDirection AudioDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticMatineeObject.MagAudioDirection>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// ByteProperty: MoveState
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticMatineeObject.EMatineeMoveState MoveState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticMatineeObject.EMatineeMoveState>(Ptr + 1269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1269); }
    }

    /// <summary>
    /// FloatProperty: SavedMatineePos
    /// </summary>
    public unsafe float SavedMatineePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
}

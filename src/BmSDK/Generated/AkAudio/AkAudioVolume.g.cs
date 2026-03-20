#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkAudioVolume<br/>
/// (flags = 0)
/// </summary>
public partial class AkAudioVolume : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkAudioVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkAudioVolume() { }

    /// <summary>
    /// Constructs a new AkAudioVolume
    /// </summary>
    public AkAudioVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkAudioVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkAudioVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkAudioVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkAudioVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkAudioVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkAudioVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkAudioVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkAudioVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkAudioVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_AkUpdate
    /// </summary>
    public unsafe System.IntPtr VfTable_AkUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// StructProperty: VfTable_AkEvaluate
    /// </summary>
    public unsafe System.IntPtr VfTable_AkEvaluate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: AkProps
    /// </summary>
    public unsafe BmSDK.Engine.AkProperties AkProps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkProperties>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: DrawBoundsComponent
    /// </summary>
    public unsafe BmSDK.Engine.AkDrawBoundsComponent DrawBoundsComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDrawBoundsComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StrProperty: DebugTag
    /// </summary>
    public unsafe BmSDK.FString DebugTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: EnvironmentSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentSettings> EnvironmentSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentSettings>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateTouching
    /// </summary>
    public unsafe bool bForceUpdateTouching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 804); }
    }

    /// <summary>
    /// BoolProperty: bSurveillanceOccluder
    /// </summary>
    public unsafe bool bSurveillanceOccluder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplier
    /// </summary>
    public unsafe float OcclusionMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// StructProperty: ParameterX
    /// </summary>
    public unsafe BmSDK.AkAudio.AkAudioVolume.FAkAxisParameter ParameterX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.AkAudioVolume.FAkAxisParameter>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// StructProperty: ParameterY
    /// </summary>
    public unsafe BmSDK.AkAudio.AkAudioVolume.FAkAxisParameter ParameterY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.AkAudioVolume.FAkAxisParameter>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: ParameterZ
    /// </summary>
    public unsafe BmSDK.AkAudio.AkAudioVolume.FAkAxisParameter ParameterZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.AkAudioVolume.FAkAxisParameter>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ArrayProperty: ParameterModifiers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.AkAudio.AkAudioVolume.FParameterModifierPair> ParameterModifiers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.AkAudio.AkAudioVolume.FParameterModifierPair>>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ArrayProperty: SwitchModifiers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.AkAudio.AkAudioVolume.FSwitchModifierPair> SwitchModifiers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.AkAudio.AkAudioVolume.FSwitchModifierPair>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: FalloffRadiusMultiplier
    /// </summary>
    public unsafe float FalloffRadiusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: ForceTouching
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.AkAudio.AkAudioVolume.FTouchingActorInfo> ForceTouching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.AkAudio.AkAudioVolume.FTouchingActorInfo>>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// StructProperty: ForceTouchingUpdateTime
    /// </summary>
    public unsafe double ForceTouchingUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// IntProperty: TouchingCount
    /// </summary>
    public unsafe int TouchingCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ArrayProperty: OverlappingVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.AkAudio.AkAudioVolume.FOverlappingVolumeInfo> OverlappingVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.AkAudio.AkAudioVolume.FOverlappingVolumeInfo>>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ArrayProperty: LinkedEmitters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.AkAudio.AkRattleEmitter> LinkedEmitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.AkAudio.AkRattleEmitter>>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: LastKnownOverlapTouchingValue
    /// </summary>
    public unsafe float LastKnownOverlapTouchingValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
}

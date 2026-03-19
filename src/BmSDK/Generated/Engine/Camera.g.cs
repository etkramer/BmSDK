#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Camera<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Camera : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Camera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Camera() { }

    /// <summary>
    /// Constructs a new Camera
    /// </summary>
    public Camera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Camera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Camera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Camera>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: PCOwner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PCOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: CameraShakeCamMod
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraShakeCamMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimInstPool_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimInstPool_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimInstPool_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimInstPool_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimInstPool_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimInstPool_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimInstPool_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }
    /// <summary>
    /// ObjectProperty: AnimInstPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimInstPool_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: AnimCameraActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimCameraActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ClassProperty: CameraShakeCamModClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraShakeCamModClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// NameProperty: CameraStyle
    /// </summary>
    public unsafe BmSDK.FName CameraStyle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: DefaultFOV
    /// </summary>
    public unsafe float DefaultFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: bLockedFOV
    /// </summary>
    public unsafe bool bLockedFOV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bConstrainAspectRatio
    /// </summary>
    public unsafe bool bConstrainAspectRatio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bEnableFading
    /// </summary>
    public unsafe bool bEnableFading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bFadeAudio
    /// </summary>
    public unsafe bool bFadeAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bForceDisableTemporalAA
    /// </summary>
    public unsafe bool bForceDisableTemporalAA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bZoomed
    /// </summary>
    public unsafe bool bZoomed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bEnableColorScaling
    /// </summary>
    public unsafe bool bEnableColorScaling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bEnableColorScaleInterp
    /// </summary>
    public unsafe bool bEnableColorScaleInterp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bUseClientSideCameraUpdates
    /// </summary>
    public unsafe bool bUseClientSideCameraUpdates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bDebugClientSideCamera
    /// </summary>
    public unsafe bool bDebugClientSideCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// BoolProperty: bShouldSendClientSideCameraUpdate
    /// </summary>
    public unsafe bool bShouldSendClientSideCameraUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: LockedFOV
    /// </summary>
    public unsafe float LockedFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: ConstrainedAspectRatio
    /// </summary>
    public unsafe float ConstrainedAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: DefaultAspectRatio
    /// </summary>
    public unsafe float DefaultAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// FloatProperty: OffAxisYawAngle
    /// </summary>
    public unsafe float OffAxisYawAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: OffAxisPitchAngle
    /// </summary>
    public unsafe float OffAxisPitchAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// StructProperty: FadeColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FadeColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: FadeAmount
    /// </summary>
    public unsafe float FadeAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: CamOverridePostProcessAlpha
    /// </summary>
    public unsafe float CamOverridePostProcessAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// StructProperty: CamPostProcessSettings
    /// </summary>
    public unsafe BmSDK.Engine.Camera.ModifierList CamPostProcessSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera.ModifierList>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// StructProperty: RenderingOverrides
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RenderingOverrides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// StructProperty: ColorScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ColorScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// StructProperty: DesiredColorScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DesiredColorScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// StructProperty: OriginalColorScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OriginalColorScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// FloatProperty: ColorScaleInterpDuration
    /// </summary>
    public unsafe float ColorScaleInterpDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// FloatProperty: ColorScaleInterpStartTime
    /// </summary>
    public unsafe float ColorScaleInterpStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// FloatProperty: SoundFadeAmount
    /// </summary>
    public unsafe float SoundFadeAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// FloatProperty: StereoConvergenceDepth
    /// </summary>
    public unsafe float StereoConvergenceDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// StructProperty: CameraCache
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// StructProperty: LastFrameCameraCache
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastFrameCameraCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// StructProperty: ViewTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ViewTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// StructProperty: PendingViewTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PendingViewTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: BlendTimeToGo
    /// </summary>
    public unsafe float BlendTimeToGo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// StructProperty: BlendParams
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BlendParams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// ArrayProperty: ModifierList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>> ModifierList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// FloatProperty: FreeCamDistance
    /// </summary>
    public unsafe float FreeCamDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// StructProperty: FreeCamOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FreeCamOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// StructProperty: FadeAlpha
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FadeAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// FloatProperty: fadeTime
    /// </summary>
    public unsafe float fadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// FloatProperty: FadeTimeRemaining
    /// </summary>
    public unsafe float FadeTimeRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// ArrayProperty: CameraLensEffects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> CameraLensEffects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// ArrayProperty: ActiveAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> ActiveAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// ArrayProperty: FreeAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> FreeAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }
}

#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RFreezeTakeDownStage<br/>
/// (size = 1096)
/// (flags = 8388626)
/// </summary>
public partial class RFreezeTakeDownStage : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RFreezeTakeDownStage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFreezeTakeDownStage() { }

    /// <summary>
    /// Constructs a new RFreezeTakeDownStage
    /// </summary>
    public RFreezeTakeDownStage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFreezeTakeDownStage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFreezeTakeDownStage(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeTakeDownStage>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeTakeDownStage>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeTakeDownStage>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeTakeDownStage>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeTakeDownStage>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeTakeDownStage>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeTakeDownStage>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: SetSpeedNormal
    /// </summary>
    public unsafe virtual void SetSpeedNormal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.SetSpeedNormal", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSpeedLow
    /// </summary>
    public unsafe virtual void SetSpeedLow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.SetSpeedLow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishAttackAttacker
    /// </summary>
    public unsafe override void FinishAttackAttacker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.FinishAttackAttacker", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoesCameraMaintainLos
    /// </summary>
    public unsafe virtual bool DoesCameraMaintainLos(BmSDK.BmGame.RInGameCinematicCam CinematicCamera)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.DoesCameraMaintainLos", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanCameraSeePoint
    /// </summary>
    public unsafe virtual bool CanCameraSeePoint(BmSDK.BmGame.RInGameCinematicCam CinematicCamera, float CameraTimeNormalised, System.Numerics.Vector3 CameraCheckTarget, BmSDK.Engine.Actor IgnoreThisActor, BmSDK.Engine.Actor IgnoreThisActorToo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.CanCameraSeePoint", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CinematicCamera, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraTimeNormalised, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCheckTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreThisActor, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreThisActorToo, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetCameraTargetBatman
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCameraTargetBatman(bool CheckEyes)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.GetCameraTargetBatman", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEyes, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCameraTargetFreeze
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetCameraTargetFreeze(bool CheckEyes)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.GetCameraTargetFreeze", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEyes, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PlayCameraAnim
    /// </summary>
    public unsafe virtual bool PlayCameraAnim(BmSDK.FName AnimName, BmSDK.Engine.AnimSet TheAnimSet, bool bCamMirrored, float FOV = default, bool bHardCut = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.PlayCameraAnim", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheAnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardCut, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: BackToPlayerCamera
    /// </summary>
    public unsafe virtual void BackToPlayerCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.BackToPlayerCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CameraCut
    /// </summary>
    public unsafe virtual void CameraCut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.CameraCut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartCamera
    /// </summary>
    public unsafe virtual void StartCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.StartCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayCameraPhase
    /// </summary>
    public unsafe virtual void PlayCameraPhase(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.PlayCameraPhase", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldUseCustomCamera
    /// </summary>
    public unsafe virtual bool ShouldUseCustomCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.ShouldUseCustomCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PlaySpecialCameraAnim
    /// </summary>
    public unsafe override bool PlaySpecialCameraAnim(BmSDK.FName AnimName, bool bCamMirrored, bool CameraCollision = default, float FOV = default, BmSDK.Engine.AnimSet CustomAnimSet = default, float BlendTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.PlaySpecialCameraAnim", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCollision, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: PlayCameraAuto
    /// </summary>
    public unsafe virtual void PlayCameraAuto()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.PlayCameraAuto", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldForceSafeCamera
    /// </summary>
    public unsafe virtual bool ShouldForceSafeCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.ShouldForceSafeCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Begin
    /// </summary>
    public unsafe override void Begin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RFreezeTakeDownStage.Begin", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: SlaveToVictim
    /// </summary>
    public unsafe bool SlaveToVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: FreezeCanBeTranslated
    /// </summary>
    public unsafe bool FreezeCanBeTranslated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: RestoredPlayerCamera
    /// </summary>
    public unsafe bool RestoredPlayerCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bCutToFirstCamera
    /// </summary>
    public unsafe bool bCutToFirstCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bSkipCameraCheck
    /// </summary>
    public unsafe bool bSkipCameraCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: GameSpeedWhenSlowedDown
    /// </summary>
    public unsafe float GameSpeedWhenSlowedDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: TransitionPeriodToSlowMotion
    /// </summary>
    public unsafe float TransitionPeriodToSlowMotion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeToRemainSlow
    /// </summary>
    public unsafe float MaxTimeToRemainSlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: EarlyOutProportion
    /// </summary>
    public unsafe float EarlyOutProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: EarlyOutTime
    /// </summary>
    public unsafe float EarlyOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ObjectProperty: AttackerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer AttackerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ArrayProperty: MultiCameraAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MultiCameraAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ObjectProperty: MultiCameraAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet MultiCameraAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: CameraPhase
    /// </summary>
    public unsafe int CameraPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// NameProperty: BackupCameraAnimation
    /// </summary>
    public unsafe BmSDK.FName BackupCameraAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: fCheckCameraCollisionFromProportion
    /// </summary>
    public unsafe float fCheckCameraCollisionFromProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: fCheckCameraCollisionToProportion
    /// </summary>
    public unsafe float fCheckCameraCollisionToProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }
}

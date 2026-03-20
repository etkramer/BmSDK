#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RGrappleGun<br/>
/// (size = 3668)
/// (flags = 144703667)
/// </summary>
public partial class RGrappleGun : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGrappleGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGrappleGun() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGrappleGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: ResetForChallenge
    /// </summary>
    public unsafe override void ResetForChallenge(bool bChallengeStarted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ResetForChallenge", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bChallengeStarted, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGrappleBoostLevel
    /// </summary>
    public unsafe virtual bool UpdateGrappleBoostLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.UpdateGrappleBoostLevel", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AddGrappleBoostPrompt
    /// </summary>
    public unsafe virtual void AddGrappleBoostPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.AddGrappleBoostPrompt", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetGrappleLoopSound
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetGrappleLoopSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetGrappleLoopSound", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFireGrappleSound
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetFireGrappleSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetFireGrappleSound", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetImpactAudioEvent
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent GetImpactAudioEvent(BmSDK.Engine.AkWwise.EAkWorldMaterial Mat)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetImpactAudioEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpdateGrappleBoostFromUpgrades
    /// </summary>
    public unsafe virtual void UpdateGrappleBoostFromUpgrades()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.UpdateGrappleBoostFromUpgrades", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerGrappleFailedEvent
    /// </summary>
    public unsafe virtual void TriggerGrappleFailedEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.TriggerGrappleFailedEvent", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAimedGrappleTargetPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAimedGrappleTargetPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetAimedGrappleTargetPoint", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetActiveHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetActiveHidePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetActiveHidePoint", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTargetHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetTargetHidePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetTargetHidePoint", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetGrappleGunDisabled
    /// </summary>
    public unsafe virtual void SetGrappleGunDisabled(bool bDisabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SetGrappleGunDisabled", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanDisableTick
    /// </summary>
    public unsafe override bool CanDisableTick()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CanDisableTick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGrappleEndLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrappleEndLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetGrappleEndLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateGrappleGunTarget
    /// </summary>
    public unsafe virtual void UpdateGrappleGunTarget(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.UpdateGrappleGunTarget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: CanAimGrapple
    /// </summary>
    public unsafe virtual bool CanAimGrapple()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CanAimGrapple", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LastHidePointTimeOut
    /// </summary>
    public unsafe virtual void LastHidePointTimeOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.LastHidePointTimeOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SucceedBoost
    /// </summary>
    public unsafe virtual void SucceedBoost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SucceedBoost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FailedBoost
    /// </summary>
    public unsafe virtual void FailedBoost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FailedBoost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckGrapplePointCollision
    /// </summary>
    public unsafe virtual bool CheckGrapplePointCollision(System.Numerics.Vector3 GrappleTargetPos, bool SwingGrapple, BmSDK.BmGame.RHidePoint HidePointToCheck = default, BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo GrapplePointToCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CheckGrapplePointCollision", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleTargetPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingGrapple, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HidePointToCheck, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePointToCheck, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 104);
    }

    /// <summary>
    /// Function: CheckCurrentGrapplePointCollision
    /// </summary>
    public unsafe virtual bool CheckCurrentGrapplePointCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CheckCurrentGrapplePointCollision", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGrappleTargetPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGrappleTargetPosition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetGrappleTargetPosition", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InitialiseGrappleWayPoints
    /// </summary>
    public unsafe virtual void InitialiseGrappleWayPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.InitialiseGrappleWayPoints", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: CalcGrappleLength
    /// </summary>
    public unsafe virtual void CalcGrappleLength()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CalcGrappleLength", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: CheckForGrappleWaypoints
    /// </summary>
    public unsafe virtual void CheckForGrappleWaypoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.CheckForGrappleWaypoints", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: NoWaypointCheck
    /// </summary>
    public unsafe virtual void NoWaypointCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.NoWaypointCheck", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverrideBeamHidePoint
    /// </summary>
    public unsafe virtual void OverrideBeamHidePoint(BmSDK.BmGame.RHidePoint_LampPostTop BeamHidePoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.OverrideBeamHidePoint", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BeamHidePoint, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: OverrideCurrentHidePoint
    /// </summary>
    public unsafe virtual void OverrideCurrentHidePoint(BmSDK.BmGame.RHidePoint NewHidePoint, bool bSwingGrapple = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.OverrideCurrentHidePoint", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHidePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSwingGrapple, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReachedGrappleWayPoint
    /// </summary>
    public unsafe virtual void ReachedGrappleWayPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ReachedGrappleWayPoint", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueGrappleTimer
    /// </summary>
    public unsafe virtual void QueueGrappleTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.QueueGrappleTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueGrapple
    /// </summary>
    public unsafe virtual void QueueGrapple(float QueueTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.QueueGrapple", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueueTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNumAvailableGrapplePoints
    /// </summary>
    public unsafe virtual int GetNumAvailableGrapplePoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetNumAvailableGrapplePoints", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AttachToBelt
    /// </summary>
    public unsafe override void AttachToBelt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.AttachToBelt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopGrappleTrails
    /// </summary>
    public unsafe virtual void StopGrappleTrails()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.StopGrappleTrails", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGrappleTrails
    /// </summary>
    public unsafe virtual void StartGrappleTrails()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.StartGrappleTrails", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffProjectiles
    /// </summary>
    public unsafe override void TurnOffProjectiles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.TurnOffProjectiles", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireProjectile
    /// </summary>
    public unsafe override void FireProjectile(System.Numerics.Vector3 ProjectileTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FireProjectile", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsPerformingChainGrapple
    /// </summary>
    public unsafe virtual bool IsPerformingChainGrapple()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.IsPerformingChainGrapple", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe override void PreRender(BmSDK.Engine.Canvas HudCanvas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.PreRender", true);
        byte* paramsPtr = stackalloc byte[196];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearGrappleInfo
    /// </summary>
    public unsafe virtual void ClearGrappleInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ClearGrappleInfo", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: DrawGrapplePointDebug
    /// </summary>
    public unsafe virtual void DrawGrapplePointDebug()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.DrawGrapplePointDebug", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: FindGrapplePointMultipleConesNative
    /// </summary>
    public unsafe virtual void FindGrapplePointMultipleConesNative(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindGrapplePointMultipleConesNative", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Cones = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: FindGrapplePointMultipleCones
    /// </summary>
    public unsafe virtual void FindGrapplePointMultipleCones(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindGrapplePointMultipleCones", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Cones = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: FindGrapplePoint
    /// </summary>
    public unsafe virtual void FindGrapplePoint(float MinAngle, System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, System.Numerics.Vector3 PlayerLocation, bool bZoomed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomed, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCheckFrame
    /// </summary>
    public unsafe virtual void UpdateCheckFrame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.UpdateCheckFrame", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: FindBestCeilingClimbPoint
    /// </summary>
    public unsafe virtual bool FindBestCeilingClimbPoint(out BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint CeilingClimbPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.FindBestCeilingClimbPoint", true);
        byte* paramsPtr = stackalloc byte[136];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CeilingClimbPoint = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 132);
    }

    /// <summary>
    /// Function: GetCurrentHidePoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RHidePoint GetCurrentHidePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetCurrentHidePoint", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetChuteMode
    /// </summary>
    public unsafe virtual void SetChuteMode(bool InChuteMode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SetChuteMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InChuteMode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleGrappleTarget
    /// </summary>
    public unsafe virtual void ToggleGrappleTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ToggleGrappleTarget", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideGrappleTarget
    /// </summary>
    public unsafe virtual void HideGrappleTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.HideGrappleTarget", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetFailedGrappleTimer
    /// </summary>
    public unsafe virtual void SetFailedGrappleTimer(float FailTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SetFailedGrappleTimer", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StoreQueuedGrapple
    /// </summary>
    public unsafe virtual void StoreQueuedGrapple()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.StoreQueuedGrapple", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Grapple
    /// </summary>
    public unsafe virtual bool Grapple(BmSDK.BmGame.RSpecialMoveConfig OverrideGrappleMove = default, bool bForceSucceed = default, bool bTryQueuedGrapple = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.Grapple", true);
        byte* paramsPtr = stackalloc byte[504];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideGrappleMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSucceed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryQueuedGrapple, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GrappleDelayedChutePoint
    /// </summary>
    public unsafe virtual void GrappleDelayedChutePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GrappleDelayedChutePoint", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearDelayedChutePointGrapple
    /// </summary>
    public unsafe virtual void ClearDelayedChutePointGrapple()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ClearDelayedChutePointGrapple", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrappleReleased
    /// </summary>
    public unsafe virtual void GrappleReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GrappleReleased", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnPlayerHasBeenMoved
    /// </summary>
    public unsafe virtual void OnPlayerHasBeenMoved()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.OnPlayerHasBeenMoved", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetController
    /// </summary>
    public unsafe virtual void SetController(BmSDK.BmGame.RPlayerController NewPC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SetController", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GivenTo
    /// </summary>
    public unsafe override void GivenTo(BmSDK.Engine.Pawn thisPawn, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GivenTo", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thisPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetGrappleTargets
    /// </summary>
    public unsafe virtual void ResetGrappleTargets()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ResetGrappleTargets", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: HasValidTarget
    /// </summary>
    public unsafe virtual bool HasValidTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.HasValidTarget", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ScriptTick
    /// </summary>
    public unsafe virtual void ScriptTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.ScriptTick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGrapplePoint
    /// </summary>
    public unsafe virtual void SetGrapplePoint(BmSDK.BmGame.RGrapplePoint NewPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SetGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPoint, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetLastGrapplePoint
    /// </summary>
    public unsafe virtual void SetLastGrapplePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.SetLastGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: InvalidateLastGrapplePoint
    /// </summary>
    public unsafe virtual void InvalidateLastGrapplePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.InvalidateLastGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: InvalidateGrapplePoint
    /// </summary>
    public unsafe virtual void InvalidateGrapplePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.InvalidateGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetLastGrapplePoint
    /// </summary>
    public unsafe virtual void GetLastGrapplePoint(out BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo GrappleInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetLastGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[80];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        GrappleInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetGrapplePoint
    /// </summary>
    public unsafe virtual void GetGrapplePoint(out BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo GrappleInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGrappleGun.GetGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[80];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        GrappleInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Struct: FGrappleDodgeAnim
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FGrappleDodgeAnim
    {
        /// <summary>
        /// FloatProperty: RightSpeed
        /// </summary>
        public unsafe float RightSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: UpSpeed
        /// </summary>
        public unsafe float UpSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: DodgeAnim
        /// </summary>
        public unsafe BmSDK.FName DodgeAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FGrappleConeDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public partial record struct FGrappleConeDefinition
    {
        /// <summary>
        /// StructProperty: CheckLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: CheckRotation
        /// </summary>
        public unsafe BmSDK.Rotator CheckRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: PlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 PlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bRunGrapple
        /// </summary>
        public unsafe bool bRunGrapple
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bZoomed
        /// </summary>
        public unsafe bool bZoomed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: ScoreBonus
        /// </summary>
        public unsafe float ScoreBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: VantagePointBonus
        /// </summary>
        public unsafe float VantagePointBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: MaxDistance
        /// </summary>
        public unsafe float MaxDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: ConeAngle
        /// </summary>
        public unsafe float ConeAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bVantagePointsOnly
        /// </summary>
        public unsafe bool bVantagePointsOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bCanSwingToTarget
        /// </summary>
        public unsafe bool bCanSwingToTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bGrapplePointsOnly
        /// </summary>
        public unsafe bool bGrapplePointsOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: ChuteGrapple
        /// </summary>
        public unsafe bool ChuteGrapple
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// ObjectProperty: ExcludeActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor ExcludeActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: SwingScoreBonus
        /// </summary>
        public unsafe float SwingScoreBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: OverrideRange
        /// </summary>
        public unsafe float OverrideRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FGrapplePointContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FGrapplePointContainer
    {
        /// <summary>
        /// StructProperty: GrapplePoint
        /// </summary>
        public unsafe System.IntPtr GrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: TargetPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: GrappleCheckPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 GrappleCheckPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StructProperty: SwingCheckPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingCheckPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Score
        /// </summary>
        public unsafe float Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: BonusScore
        /// </summary>
        public unsafe float BonusScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: PredVolumeBonus
        /// </summary>
        public unsafe float PredVolumeBonus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: GrappleClear
        /// </summary>
        public unsafe bool GrappleClear
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: GrappleChecked
        /// </summary>
        public unsafe bool GrappleChecked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: MustSwingToGrapplePoint
        /// </summary>
        public unsafe bool MustSwingToGrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Enum: EGrappleFailReason
    /// </summary>
    public enum EGrappleFailReason
    {
        GFR_Success = 0,
        GFR_CollisionFail = 1,
        GFR_LowerThanTopScore = 2,
        GFR_FinalAngleFail = 3,
        GFR_LineOutsideAngleLimit = 4,
        GFR_BelowBatman = 5,
        GFR_OutsideRadiusCheck = 6,
        GFR_TooHighOrLow = 7,
        GFR_TooLow = 8,
        GFR_TooFarAway = 9,
        GFR_WrongSide = 10,
        GFR_EarlyRadiusCheck = 11,
        GFR_InvalidPoint = 12,
        GFR_MaxDrawColours = 13,
        GFR_MAX = 14,
    }

    /// <summary>
    /// Struct: FAvailableVantagePoints
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FAvailableVantagePoints
    {
        /// <summary>
        /// ArrayProperty: PotentialHidePoints
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FHidePointInfo> PotentialHidePoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FHidePointInfo>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: CurrentHidePointIter
        /// </summary>
        public unsafe int CurrentHidePointIter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FHidePointInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FHidePointInfo
    {
        /// <summary>
        /// ObjectProperty: HidePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint HidePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: HidePointAngle
        /// </summary>
        public unsafe float HidePointAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bHidePointBlocked
        /// </summary>
        public unsafe bool bHidePointBlocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleHeight
    /// </summary>
    public unsafe float MaxGrappleHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleHeight
    /// </summary>
    public unsafe float MinGrappleHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleHorizontalDistance
    /// </summary>
    public unsafe float MaxGrappleHorizontalDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleAngle
    /// </summary>
    public unsafe float MaxGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalDistanceForAimedGrapple
    /// </summary>
    public unsafe float MaxHorizontalDistanceForAimedGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: MaxAimedGrappleAngle
    /// </summary>
    public unsafe float MaxAimedGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// FloatProperty: RunGrappleAngle
    /// </summary>
    public unsafe float RunGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// FloatProperty: WallStickGrappleAngle
    /// </summary>
    public unsafe float WallStickGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// FloatProperty: EscapeGrappleAngle
    /// </summary>
    public unsafe float EscapeGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireGlideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFireGlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireRunningMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFireRunningMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireFallingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFireFallingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// ObjectProperty: FailedGrappleFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FailedGrappleFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// ObjectProperty: VantagePointGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig VantagePointGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// ObjectProperty: RailingFireGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingFireGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// ObjectProperty: ShimmyFireGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShimmyFireGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ObjectProperty: ChainFireGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ChainFireGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: ChainFireBeamGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ChainFireBeamGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireWithBackFlipMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFireWithBackFlipMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireTakedownEscape
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFireTakedownEscape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndShimmyMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndShimmyMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: CustomGrappleEndDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomGrappleEndDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbFlat
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndClimbFlat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndClimbRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbOverWall
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndClimbOverWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunFlat
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndRunFlat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunFlatNoRoll
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndRunFlatNoRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndRunRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunOverWall
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndRunOverWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndFly
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndFly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndFlyRail
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndFlyRail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// ObjectProperty: GrappleBoostToDive
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleBoostToDive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndFly180
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndFly180
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndOnRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleEndOnRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// ObjectProperty: SwingToShimmyMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController SwingToShimmyMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// ObjectProperty: SwingToStandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController SwingToStandMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// ObjectProperty: DiveSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFromChuteMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrappleFromChuteMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileWithRope Projectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileWithRope>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// ObjectProperty: LastHighlightedChute
    /// </summary>
    public unsafe BmSDK.BmGame.RSwingChutePointBase LastHighlightedChute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSwingChutePointBase>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// ObjectProperty: CurrentHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint CurrentHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// ObjectProperty: ActiveHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint ActiveHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// ObjectProperty: QueuedHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint QueuedHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// ObjectProperty: GrappleBoostSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GrappleBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// ObjectProperty: SucceedBoostSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SucceedBoostSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// ObjectProperty: FailedBoostSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FailedBoostSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// ObjectProperty: ImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// ObjectProperty: FireGrappleSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireGrappleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// ObjectProperty: GrappleLoopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GrappleLoopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// ObjectProperty: PassiveImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PassiveImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// ObjectProperty: PassiveFireGrappleSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PassiveFireGrappleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// ObjectProperty: PassiveGrappleLoopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PassiveGrappleLoopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// ObjectProperty: LastHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LastHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ObjectProperty: LastSwingPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LastSwingPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// ObjectProperty: CurrentDelayedChuteTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RSwingChutePointBase CurrentDelayedChuteTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSwingChutePointBase>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ObjectProperty: UseSpecialOctTree
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction UseSpecialOctTree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// ObjectProperty: WaterRescueGrappleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WaterRescueGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ClassProperty: GrappleProjectileClass
    /// </summary>
    public unsafe BmSDK.Class GrappleProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ComponentProperty: GrappleRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent GrappleRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// FloatProperty: IconSize
    /// </summary>
    public unsafe float IconSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// IntProperty: MinGrapplePitch
    /// </summary>
    public unsafe int MinGrapplePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// IntProperty: MinEdgeSwingPitch
    /// </summary>
    public unsafe int MinEdgeSwingPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// IntProperty: MinVantagePitch
    /// </summary>
    public unsafe int MinVantagePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// FloatProperty: VantagePointGrappleAngle
    /// </summary>
    public unsafe float VantagePointGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// FloatProperty: ChutePointGrappleAngle
    /// </summary>
    public unsafe float ChutePointGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// FloatProperty: ChutePointGrappleAngleWeight
    /// </summary>
    public unsafe float ChutePointGrappleAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// FloatProperty: MaxOWSwingRange
    /// </summary>
    public unsafe float MaxOWSwingRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// FloatProperty: DummyPropertyToReplaceMinGrappleBoostRange
    /// </summary>
    public unsafe float DummyPropertyToReplaceMinGrappleBoostRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// NameProperty: CustomHangCamera
    /// </summary>
    public unsafe BmSDK.FName CustomHangCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// BoolProperty: bCantShimmyOnNextHang
    /// </summary>
    public unsafe bool bCantShimmyOnNextHang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bCantAutoPopUpOnNextHang
    /// </summary>
    public unsafe bool bCantAutoPopUpOnNextHang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: CurrentSwingGrapple
    /// </summary>
    public unsafe bool CurrentSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bFadingOutChuteHighlight
    /// </summary>
    public unsafe bool bFadingOutChuteHighlight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bTargettingCeiling
    /// </summary>
    public unsafe bool bTargettingCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: ActiveSwingGrapple
    /// </summary>
    public unsafe bool ActiveSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: QueuedSwingGrapple
    /// </summary>
    public unsafe bool QueuedSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bGrappleQueued
    /// </summary>
    public unsafe bool bGrappleQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bPreFire
    /// </summary>
    public unsafe bool bPreFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bShowingGrappleIcon
    /// </summary>
    public unsafe bool bShowingGrappleIcon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bGrapplingFromChute
    /// </summary>
    public unsafe bool bGrapplingFromChute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bRenderGrappleDebug
    /// </summary>
    public unsafe bool bRenderGrappleDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bUseReverseCameraForSwinging
    /// </summary>
    public unsafe bool bUseReverseCameraForSwinging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDoingGrappleSpaceTest
    /// </summary>
    public unsafe bool bDoingGrappleSpaceTest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bVantagePointCheckFrame
    /// </summary>
    public unsafe bool bVantagePointCheckFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bRunGrapple
    /// </summary>
    public unsafe bool bRunGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bEdgeSwingGrapple
    /// </summary>
    public unsafe bool bEdgeSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bCanSwingToPoints
    /// </summary>
    public unsafe bool bCanSwingToPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bGrappleSelectionDebug
    /// </summary>
    public unsafe bool bGrappleSelectionDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bAllowAimingWhenFalling
    /// </summary>
    public unsafe bool bAllowAimingWhenFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bCatwomanGrappleGun
    /// </summary>
    public unsafe bool bCatwomanGrappleGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bUnusableGrappleTarget
    /// </summary>
    public unsafe bool bUnusableGrappleTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDoingGlideStick
    /// </summary>
    public unsafe bool bDoingGlideStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bHarleyGrappleGun
    /// </summary>
    public unsafe bool bHarleyGrappleGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bUseGrappleOctree
    /// </summary>
    public unsafe bool bUseGrappleOctree
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: LastSwingGrapple
    /// </summary>
    public unsafe bool LastSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDebugTreatAsOverworld
    /// </summary>
    public unsafe bool bDebugTreatAsOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bOverrideGrappleRendering
    /// </summary>
    public unsafe bool bOverrideGrappleRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bWallStick
    /// </summary>
    public unsafe bool bWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrappleChecks
    /// </summary>
    public unsafe bool bDebugGrappleChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingClimbPoints
    /// </summary>
    public unsafe bool bDebugCeilingClimbPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: StateOverridesTick
    /// </summary>
    public unsafe bool StateOverridesTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// BoolProperty: bGrappleGunDisabled
    /// </summary>
    public unsafe bool bGrappleGunDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// BoolProperty: bForcedGrapple
    /// </summary>
    public unsafe bool bForcedGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// BoolProperty: bGrapplingToWindow
    /// </summary>
    public unsafe bool bGrapplingToWindow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// BoolProperty: bCheckFearGas
    /// </summary>
    public unsafe bool bCheckFearGas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// FloatProperty: LookFarwardFallingTime
    /// </summary>
    public unsafe float LookFarwardFallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalRange
    /// </summary>
    public unsafe float MaxHorizontalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// StructProperty: CurrentTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: CurrentTargetRadius
    /// </summary>
    public unsafe float CurrentTargetRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// StructProperty: GrapplePoint
    /// </summary>
    public unsafe System.IntPtr GrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// StructProperty: CeilingTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 CeilingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// StructProperty: ActiveGrappleTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 ActiveGrappleTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// StructProperty: ActiveOutwardNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 ActiveOutwardNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// StructProperty: ActiveGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo ActiveGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// StructProperty: QueuedGrappleTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 QueuedGrappleTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// StructProperty: QueuedOutwardNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 QueuedOutwardNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// StructProperty: QueuedGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo QueuedGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// StructProperty: CurrentTarget2
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentTarget2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// StructProperty: GrapplePoint2
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo GrapplePoint2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// StructProperty: HideLinkSwingTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 HideLinkSwingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// FloatProperty: GrappleLength
    /// </summary>
    public unsafe float GrappleLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }
    }

    /// <summary>
    /// IntProperty: RopeInitTimer
    /// </summary>
    public unsafe int RopeInitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// FloatProperty: VantagePointSwingRate
    /// </summary>
    public unsafe float VantagePointSwingRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// FloatProperty: StandingSwingRate
    /// </summary>
    public unsafe float StandingSwingRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// ArrayProperty: GrappleTrailBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> GrappleTrailBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2952); }
    }

    /// <summary>
    /// ArrayProperty: GrappleTrailMirrorBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> GrappleTrailMirrorBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2968); }
    }

    /// <summary>
    /// ArrayProperty: GrappleTrail
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent> GrappleTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent>>(Ptr + 2984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }
    }

    /// <summary>
    /// FloatProperty: DisplayFailedGrappleTime
    /// </summary>
    public unsafe float DisplayFailedGrappleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// FloatProperty: OriginalGrappleLength
    /// </summary>
    public unsafe float OriginalGrappleLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// FloatProperty: VantagePointBias
    /// </summary>
    public unsafe float VantagePointBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// NameProperty: PreGrappleDestState
    /// </summary>
    public unsafe BmSDK.FName PreGrappleDestState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// FloatProperty: GrappleAccelTime
    /// </summary>
    public unsafe float GrappleAccelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// IntProperty: FlyingGrapplePitch
    /// </summary>
    public unsafe int FlyingGrapplePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }

    /// <summary>
    /// StructProperty: AimedHidePoints
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints AimedHidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// StructProperty: EscapeHidePoints
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints EscapeHidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun.FAvailableVantagePoints>(Ptr + 3048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3048); }
    }

    /// <summary>
    /// IntProperty: CurrentGrapplePointToCheck
    /// </summary>
    public unsafe int CurrentGrapplePointToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }

    /// <summary>
    /// IntProperty: NumValidGrapplePoints
    /// </summary>
    public unsafe int NumValidGrapplePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }

    /// <summary>
    /// FloatProperty: HidePointDistWeight
    /// </summary>
    public unsafe float HidePointDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// FloatProperty: HidePointAngleWeight
    /// </summary>
    public unsafe float HidePointAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3080); }
    }

    /// <summary>
    /// FloatProperty: HidePointAnglePower
    /// </summary>
    public unsafe float HidePointAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }

    /// <summary>
    /// FloatProperty: AngleToNormalWeight
    /// </summary>
    public unsafe float AngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3088); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointDistWeight
    /// </summary>
    public unsafe float RunningHidePointDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointAngleWeight
    /// </summary>
    public unsafe float RunningHidePointAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3096); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointAnglePower
    /// </summary>
    public unsafe float RunningHidePointAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// FloatProperty: RunningAngleToNormalWeight
    /// </summary>
    public unsafe float RunningAngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3104); }
    }

    /// <summary>
    /// FloatProperty: RunningStickyWeight
    /// </summary>
    public unsafe float RunningStickyWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3108); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingDistWeight
    /// </summary>
    public unsafe float EdgeSwingDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3112); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAngleWeight
    /// </summary>
    public unsafe float EdgeSwingAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAnglePower
    /// </summary>
    public unsafe float EdgeSwingAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAngleToNormalWeight
    /// </summary>
    public unsafe float EdgeSwingAngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// FloatProperty: ChuteAngleWeight
    /// </summary>
    public unsafe float ChuteAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }
    }

    /// <summary>
    /// FloatProperty: ChuteAnglePower
    /// </summary>
    public unsafe float ChuteAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }

    /// <summary>
    /// FloatProperty: ChuteDistWeight
    /// </summary>
    public unsafe float ChuteDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }
    }

    /// <summary>
    /// FloatProperty: RunningGrappleAngleTan
    /// </summary>
    public unsafe float RunningGrappleAngleTan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3140); }
    }

    /// <summary>
    /// FloatProperty: OffScreenLRIconBias
    /// </summary>
    public unsafe float OffScreenLRIconBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// StructProperty: OffScreenArrowRot
    /// </summary>
    public unsafe BmSDK.Rotator OffScreenArrowRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// ByteProperty: GrapplePlayerId
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.ELocalGrapplePlayer GrapplePlayerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.ELocalGrapplePlayer>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// ByteProperty: LocalPlayerId
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.ELocalGrapplePlayer LocalPlayerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.ELocalGrapplePlayer>(Ptr + 3161); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3161); }
    }

    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DebugDrawColor_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// StructProperty: DesiredGrappleIconPos
    /// </summary>
    public unsafe System.Numerics.Vector3 DesiredGrappleIconPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }

    /// <summary>
    /// StructProperty: GrappleIconOriginalPos
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleIconOriginalPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// FloatProperty: GrappleIconTravelTime
    /// </summary>
    public unsafe float GrappleIconTravelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// FloatProperty: OldGrapplePointTime
    /// </summary>
    public unsafe float OldGrapplePointTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// FloatProperty: GrappleLagTime
    /// </summary>
    public unsafe float GrappleLagTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }
    }

    /// <summary>
    /// FloatProperty: AerialGrappleRange
    /// </summary>
    public unsafe float AerialGrappleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// FloatProperty: NoAerialGrappelIfWillHitTime
    /// </summary>
    public unsafe float NoAerialGrappelIfWillHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3256); }
    }

    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWayPoints_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3260); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWayPoints_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWayPoints_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3284); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWayPoints_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWayPoints_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3308); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWayPoints_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWayPoints_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWayPoints_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3344); }
    }

    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleSafePoint_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleSafePoint_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleSafePoint_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleSafePoint_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleSafePoint_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3404); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleSafePoint_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3416); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleSafePoint_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleSafePoint_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }

    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3452); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3460); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3468); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3472); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3476); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// IntProperty: CurrentGrappleWayPoint
    /// </summary>
    public unsafe int CurrentGrappleWayPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// StructProperty: LastClearGrapplePos
    /// </summary>
    public unsafe System.Numerics.Vector3 LastClearGrapplePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// StructProperty: GrappleWaypointFallBack
    /// </summary>
    public unsafe System.Numerics.Vector3 GrappleWaypointFallBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// IntProperty: NumGrapplePointsToCheckPerFrame
    /// </summary>
    public unsafe int NumGrapplePointsToCheckPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// StructProperty: LastGrapplePoint
    /// </summary>
    public unsafe System.IntPtr LastGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }

    /// <summary>
    /// StructProperty: LastGrapplePointTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 LastGrapplePointTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3524); }
    }

    /// <summary>
    /// FloatProperty: LastGrapplePointTime
    /// </summary>
    public unsafe float LastGrapplePointTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// FloatProperty: GrapplePointThinkingTime
    /// </summary>
    public unsafe float GrapplePointThinkingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3540); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraHeight
    /// </summary>
    public unsafe float MaxGrappleBoostExtraHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraSpeed
    /// </summary>
    public unsafe float MaxGrappleBoostExtraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3548); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostHeightFactor
    /// </summary>
    public unsafe float GrappleBoostHeightFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraHeightMk3
    /// </summary>
    public unsafe float MaxGrappleBoostExtraHeightMk3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3556); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraSpeedMk3
    /// </summary>
    public unsafe float MaxGrappleBoostExtraSpeedMk3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostHeightFactorMk3
    /// </summary>
    public unsafe float GrappleBoostHeightFactorMk3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraHeightMk4
    /// </summary>
    public unsafe float MaxGrappleBoostExtraHeightMk4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraSpeedMk4
    /// </summary>
    public unsafe float MaxGrappleBoostExtraSpeedMk4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostHeightFactorMk4
    /// </summary>
    public unsafe float GrappleBoostHeightFactorMk4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// IntProperty: GrappleBoostLvl
    /// </summary>
    public unsafe int GrappleBoostLvl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// FloatProperty: ChainGrappleRange
    /// </summary>
    public unsafe float ChainGrappleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ArrayProperty: CheckedGrapplePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrapplePointContainer> CheckedGrapplePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrapplePointContainer>>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// StructProperty: CurrentOutwardNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentOutwardNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }

    /// <summary>
    /// FloatProperty: GlideStickForwardTilt
    /// </summary>
    public unsafe float GlideStickForwardTilt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// FloatProperty: GlideStickCheckLocationShift
    /// </summary>
    public unsafe float GlideStickCheckLocationShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3620); }
    }

    /// <summary>
    /// IntProperty: GrappleFilter
    /// </summary>
    public unsafe int GrappleFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// IntProperty: HidePointFilter
    /// </summary>
    public unsafe int HidePointFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// StructProperty: PlayerPositionCheckOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 PlayerPositionCheckOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// FloatProperty: fDelayedChuteTargetButtonHoldTime
    /// </summary>
    public unsafe float fDelayedChuteTargetButtonHoldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3644); }
    }

    /// <summary>
    /// FloatProperty: GrappleStiffness
    /// </summary>
    public unsafe float GrappleStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ArrayProperty: GrappleDodgeAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleDodgeAnim> GrappleDodgeAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleDodgeAnim>>(Ptr + 3652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3652); }
    }
}

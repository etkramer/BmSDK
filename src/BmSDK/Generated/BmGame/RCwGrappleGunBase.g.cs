#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCwGrappleGunBase<br/>
/// (size = 7440)
/// (flags = 0)
/// </summary>
public partial class RCwGrappleGunBase : BmSDK.BmGame.RGrappleGun, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCwGrappleGunBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCwGrappleGunBase() { }

    /// <summary>
    /// Constructs a new RCwGrappleGunBase
    /// </summary>
    public RCwGrappleGunBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCwGrappleGunBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwGrappleGunBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: GetLastGrapplePointFromClimbInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo GetLastGrapplePointFromClimbInfo(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetLastGrapplePointFromClimbInfo", true);
        byte* paramsPtr = stackalloc byte[1176];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo>(paramsPtr + 1096);
    }

    /// <summary>
    /// Function: SetGrapplePointFromClimbInfo
    /// </summary>
    public unsafe void SetGrapplePointFromClimbInfo(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.SetGrapplePointFromClimbInfo", true);
        byte* paramsPtr = stackalloc byte[1096];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: PointAndLineCheck
    /// </summary>
    public unsafe bool PointAndLineCheck(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, System.Numerics.Vector3 Extent, int ExtraTraceFlags = default, bool bIgnoreRailings = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.PointAndLineCheck", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraTraceFlags, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreRailings, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 72);
    }

    /// <summary>
    /// Function: GetChainStartLocator
    /// </summary>
    public unsafe BmSDK.BmGame.RClimbLocator GetChainStartLocator(System.Numerics.Vector3 PlayerLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetChainStartLocator", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RClimbLocator>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetLocatorChainLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetLocatorChainLocation(BmSDK.BmGame.RClimbLocator LowestChainLocator, System.Numerics.Vector3 InLocation, System.Numerics.Vector3 TargetLocation, bool bAlignLowerPoints = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetLocatorChainLocation", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LowestChainLocator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlignLowerPoints, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: HandleGlobalPounceTargeting
    /// </summary>
    public unsafe void HandleGlobalPounceTargeting()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.HandleGlobalPounceTargeting", true);
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
    /// Function: PickNextLowerSwingHeight
    /// </summary>
    public unsafe bool PickNextLowerSwingHeight(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.PickNextLowerSwingHeight", true);
        byte* paramsPtr = stackalloc byte[1100];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 1096);
    }

    /// <summary>
    /// Function: CheckForCeilingTarget
    /// </summary>
    public unsafe bool CheckForCeilingTarget(out System.Numerics.Vector3 CeilingTargetLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckForCeilingTarget", true);
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CeilingTargetLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: CheckThisGrapple
    /// </summary>
    public unsafe bool CheckThisGrapple(BmSDK.BmGame.RGrapplePoint ThisGrapplePoint = default, BmSDK.BmGame.RHidePoint ThisHidePoint = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckThisGrapple", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisHidePoint, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetInBoundVector
    /// </summary>
    public unsafe System.Numerics.Vector3 GetInBoundVector(System.Numerics.Vector3 StartVelocity, System.Numerics.Vector3 EndVelocity)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetInBoundVector", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: StoreCurrentClimbInfo
    /// </summary>
    public unsafe void StoreCurrentClimbInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.StoreCurrentClimbInfo", true);
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
    /// Function: DrawPounceBlockingVolumes
    /// </summary>
    public unsafe bool DrawPounceBlockingVolumes(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bDrawPersistent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.DrawPounceBlockingVolumes", true);
        byte* paramsPtr = stackalloc byte[1104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 1096);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 1100);
    }

    /// <summary>
    /// Function: CheckWallPounce
    /// </summary>
    public unsafe bool CheckWallPounce(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, int FromPoint, bool bOptimisePass, bool bTweakFinalPounce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckWallPounce", true);
        byte* paramsPtr = stackalloc byte[1320];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromPoint, paramsPtr + 1304);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptimisePass, paramsPtr + 1308);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTweakFinalPounce, paramsPtr + 1312);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        NewPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 1096);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 1316);
    }

    /// <summary>
    /// Function: OptimisePath
    /// </summary>
    public unsafe void OptimisePath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bIgnoreDangleEdges)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.OptimisePath", true);
        byte* paramsPtr = stackalloc byte[1100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDangleEdges, paramsPtr + 1096);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetClosestLandEdge
    /// </summary>
    public unsafe bool GetClosestLandEdge(System.Numerics.Vector3 OriginalLocation, System.Numerics.Vector3 OriginalNormal, out BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FClimbLedges> Ledges, float HTolerance, float VToleranceUp, float VExtraDangleToleranceUp, float VToleranceDown, bool bIgnoreLimits, bool bIgnoreDangle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetClosestLandEdge", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HTolerance, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VToleranceUp, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VExtraDangleToleranceUp, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VToleranceDown, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreLimits, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDangle, paramsPtr + 60);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Ledges = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FClimbLedges>>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 64);
    }

    /// <summary>
    /// Function: DrawClimbRoute
    /// </summary>
    public unsafe void DrawClimbRoute(bool bPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.DrawClimbRoute", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsWallClimbMove
    /// </summary>
    public unsafe bool IsWallClimbMove(BmSDK.BmGame.RSpecialMoveConfig Config)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsWallClimbMove", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: StartWallClimbCamera
    /// </summary>
    public unsafe void StartWallClimbCamera(System.Numerics.Vector3 CurrentLandLocation, int FirstClimbPointIndex = default, bool bEstimatedLandPoint = default, bool bFromSwing = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.StartWallClimbCamera", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLandLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstClimbPointIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEstimatedLandPoint, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromSwing, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanClimbToHidePoint
    /// </summary>
    public unsafe bool CanClimbToHidePoint(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 GrappleLocation, System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CanClimbToHidePoint", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: CanClimbToGrapplePoint
    /// </summary>
    public unsafe bool CanClimbToGrapplePoint(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 GrappleLocation, System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CanClimbToGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: ClampToLineSegment
    /// </summary>
    public unsafe System.Numerics.Vector3 ClampToLineSegment(System.Numerics.Vector3 P, System.Numerics.Vector3 A, System.Numerics.Vector3 B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.ClampToLineSegment", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: InitialWallCheck
    /// </summary>
    public unsafe bool InitialWallCheck(System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 Right, float OutTolerance, float InTolerance, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 TargetWallLocation, out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, BmSDK.BmGame.RCwGrappleGunBase.EStartPoints StartCheck, bool bForcePounceCheck, out System.Numerics.Vector3 NewWallLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.InitialWallCheck", true);
        byte* paramsPtr = stackalloc byte[300];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Right, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutTolerance, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTolerance, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWallLocation, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCheck, paramsPtr + 276);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcePounceCheck, paramsPtr + 280);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 68);
        NewWallLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 284);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 296);
    }

    /// <summary>
    /// Function: CreateClimbRoute
    /// </summary>
    public unsafe bool CreateClimbRoute(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, bool bPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CreateClimbRoute", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 132);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 136);
    }

    /// <summary>
    /// Function: CheckPounceToGrapple
    /// </summary>
    public unsafe bool CheckPounceToGrapple(System.Numerics.Vector3 TargetLoc, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 playerLoc, bool bDrawDebug = default, bool bDrawPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckPounceToGrapple", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playerLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: InitialPathCheck
    /// </summary>
    public unsafe bool InitialPathCheck(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 TargetWallLocation, System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 CheckExtent, bool bLimitCheckToPlane)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.InitialPathCheck", true);
        byte* paramsPtr = stackalloc byte[276];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWallLocation, paramsPtr + 220);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 232);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 244);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckExtent, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitCheckToPlane, paramsPtr + 268);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 272);
    }

    /// <summary>
    /// Function: CheckPounceToWall
    /// </summary>
    public unsafe bool CheckPounceToWall(System.Numerics.Vector3 WallLoc, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 playerLoc, bool bLimitCheckToPlane, bool bDrawDebug = default, bool bDrawPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckPounceToWall", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playerLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitCheckToPlane, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: GetBestWallClimbIndex
    /// </summary>
    public unsafe int GetBestWallClimbIndex(System.Numerics.Vector3 EndLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetBestWallClimbIndex", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetAerialSwingGrappleTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 GetAerialSwingGrappleTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingGrappleTarget", true);
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
    /// Function: GetAerialSwingTargetNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 GetAerialSwingTargetNormal(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingTargetNormal", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetAerialSwingTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetAerialSwingTargetLocation(bool bOnlyEstimate = default, bool bOnWall = default, bool bDebugDraw = default, bool bDrawPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingTargetLocation", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnWall, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetAerialSwingEstimatedTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 GetAerialSwingEstimatedTarget(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingEstimatedTarget", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetIdealSwingParameters
    /// </summary>
    public unsafe void GetIdealSwingParameters(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, out float IdealSwingTime, out float IdealSwingLength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetIdealSwingParameters", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IdealSwingTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 36);
        IdealSwingLength = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 40);
        return;
    }

    /// <summary>
    /// Function: GetAerialSwingWallEndParams
    /// </summary>
    public unsafe bool GetAerialSwingWallEndParams(out System.Numerics.Vector3 PlayerLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingWallEndParams", true);
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetAerialSwingEndParams
    /// </summary>
    public unsafe void GetAerialSwingEndParams(out System.Numerics.Vector3 PlayerLocation, bool bOnlyEstimate = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingEndParams", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetAerialSwingStartParams
    /// </summary>
    public unsafe bool GetAerialSwingStartParams(out System.Numerics.Vector3 Origin, out System.Numerics.Vector3 StartVelocity, out float StartTime, bool bDrawDebug)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingStartParams", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        StartVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        StartTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: IsValidClimbStartPoint
    /// </summary>
    public unsafe bool IsValidClimbStartPoint(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath CheckPath, bool bNewPath = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsValidClimbStartPoint", true);
        byte* paramsPtr = stackalloc byte[216];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewPath, paramsPtr + 208);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CheckPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 212);
    }

    /// <summary>
    /// Function: GetEdgeSwingGrappleTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 GetEdgeSwingGrappleTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingGrappleTarget", true);
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
    /// Function: GetEdgeSwingGrappleTargetingParams
    /// </summary>
    public unsafe void GetEdgeSwingGrappleTargetingParams(out System.Numerics.Vector3 Origin, out BmSDK.Rotator AimDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingGrappleTargetingParams", true);
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        AimDirection = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetEdgeSwingWallLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetEdgeSwingWallLocation(out System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingWallLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetEdgeSwingWallEndParams
    /// </summary>
    public unsafe void GetEdgeSwingWallEndParams(out System.Numerics.Vector3 PlayerLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingWallEndParams", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetEdgeSwingEndParams
    /// </summary>
    public unsafe void GetEdgeSwingEndParams(out System.Numerics.Vector3 PlayerLocation, bool bOnlyEstimate = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingEndParams", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetEdgeSwingTargetNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 GetEdgeSwingTargetNormal(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingTargetNormal", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetEdgeSwingTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetEdgeSwingTargetLocation(bool bOnlyEstimate = default, bool bOnWall = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingTargetLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnWall, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetEdgeSwingEstimatedTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 GetEdgeSwingEstimatedTarget(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingEstimatedTarget", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetEdgeSwingStartParams
    /// </summary>
    public unsafe bool GetEdgeSwingStartParams(out System.Numerics.Vector3 Origin, out System.Numerics.Vector3 StartVelocity, out float StartTime, bool bDrawDebug)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingStartParams", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        StartVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        StartTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: IsWallClimbStartInDirectPounceRange
    /// </summary>
    public unsafe bool IsWallClimbStartInDirectPounceRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsWallClimbStartInDirectPounceRange", true);
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
    /// Function: IsHidePointInClimbDistance
    /// </summary>
    public unsafe bool IsHidePointInClimbDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsHidePointInClimbDistance", true);
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
    /// Function: IsHidePointInPounceDistance
    /// </summary>
    public unsafe bool IsHidePointInPounceDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsHidePointInPounceDistance", true);
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
    /// Function: IsGrapplePointInClimbDistance
    /// </summary>
    public unsafe bool IsGrapplePointInClimbDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsGrapplePointInClimbDistance", true);
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
    /// Function: IsGrapplePointInPounceDistance
    /// </summary>
    public unsafe bool IsGrapplePointInPounceDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsGrapplePointInPounceDistance", true);
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
    /// Function: TraceGroundPath
    /// </summary>
    public unsafe bool TraceGroundPath(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 DirXY, int Steps, float HeightTolerance, bool bDebugExtraPounce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.TraceGroundPath", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DirXY, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Steps, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightTolerance, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugExtraPounce, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: TraceGround
    /// </summary>
    public unsafe bool TraceGround(out System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Direction, out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, bool bDebugExtraPounce)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.TraceGround", true);
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugExtraPounce, paramsPtr + 156);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 160);
    }

    /// <summary>
    /// Function: CanLongPounce
    /// </summary>
    public unsafe bool CanLongPounce(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bHideOrGrapplePoint, System.Numerics.Vector3 WallLocation, out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, bool bDebugLongPounce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CanLongPounce", true);
        byte* paramsPtr = stackalloc byte[1252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHideOrGrapplePoint, paramsPtr + 1096);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 1100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugLongPounce, paramsPtr + 1244);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 1112);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 1248);
    }

    /// <summary>
    /// Function: CheckLongPounceFloor
    /// </summary>
    public unsafe bool CheckLongPounceFloor(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, bool bDebugDraw = default, bool bDebugLongPounce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckLongPounceFloor", true);
        byte* paramsPtr = stackalloc byte[168];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 156);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugLongPounce, paramsPtr + 160);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 164);
    }

    /// <summary>
    /// Function: IsLongPounceDist
    /// </summary>
    public unsafe bool IsLongPounceDist(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 WallLocation, bool bDirectPounceCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsLongPounceDist", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectPounceCheck, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: CheckAerialSwing
    /// </summary>
    public unsafe bool CheckAerialSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckAerialSwing", true);
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
    /// Function: CheckAerialSwingCollision
    /// </summary>
    public unsafe bool CheckAerialSwingCollision(out System.Numerics.Vector3 FirstHitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckAerialSwingCollision", true);
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: CheckEdgeSwingCollision
    /// </summary>
    public unsafe bool CheckEdgeSwingCollision(out System.Numerics.Vector3 FirstHitLocation, bool bTryShortJump = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckEdgeSwingCollision", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryShortJump, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: UpdateInitialLocator
    /// </summary>
    public unsafe bool UpdateInitialLocator(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath CheckPath, bool bNewPath = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.UpdateInitialLocator", true);
        byte* paramsPtr = stackalloc byte[348];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewPath, paramsPtr + 340);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        CheckPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 132);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 344);
    }

    /// <summary>
    /// Function: CheckSwingFromEdge
    /// </summary>
    public unsafe bool CheckSwingFromEdge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckSwingFromEdge", true);
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
    /// Function: GotSwingTargetPoint
    /// </summary>
    public unsafe bool GotSwingTargetPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GotSwingTargetPoint", true);
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
    /// Function: GotEdgeSwingTargetPoint
    /// </summary>
    public unsafe bool GotEdgeSwingTargetPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GotEdgeSwingTargetPoint", true);
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
    /// Function: IsAutoSwingToGargoyle
    /// </summary>
    public unsafe bool IsAutoSwingToGargoyle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsAutoSwingToGargoyle", true);
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
    /// Function: IsAutoSwing
    /// </summary>
    public unsafe bool IsAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsAutoSwing", true);
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
    /// Function: CheckDelayedSwing
    /// </summary>
    public unsafe bool CheckDelayedSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckDelayedSwing", true);
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
    /// Function: HandlePounceTargeting
    /// </summary>
    public unsafe void HandlePounceTargeting(bool bGrappleCheck = default, int Iteration = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.HandlePounceTargeting", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGrappleCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Iteration, paramsPtr + 4);
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
    /// Function: UpdateSwingPaths
    /// </summary>
    public unsafe bool UpdateSwingPaths()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.UpdateSwingPaths", true);
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
    /// Function: SwingLineCheck
    /// </summary>
    public unsafe bool SwingLineCheck(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 CheckExtent, bool bStartWithPointCheck, bool bDrawDebug = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.SwingLineCheck", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckExtent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStartWithPointCheck, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    /// <summary>
    /// Function: GetJumpVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 GetJumpVelocity(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetJumpVelocity", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: UpdateFlightPath
    /// </summary>
    public unsafe void UpdateFlightPath(float DeltaTime, bool bModifyTranitionTime, bool bFirstFrame)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.UpdateFlightPath", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bModifyTranitionTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirstFrame, paramsPtr + 8);
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
    /// Function: GetFlightPathDeltaTangent
    /// </summary>
    public unsafe System.Numerics.Vector3 GetFlightPathDeltaTangent(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SP, float Proportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetFlightPathDeltaTangent", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SP = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: GetFlightPathTangent
    /// </summary>
    public unsafe System.Numerics.Vector3 GetFlightPathTangent(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SP, float Proportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetFlightPathTangent", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SP = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: GetFlightPathPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 GetFlightPathPosition(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SP, float Proportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetFlightPathPosition", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SP = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: DrawSwingPath
    /// </summary>
    public unsafe void DrawSwingPath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo, bool bPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.DrawSwingPath", true);
        byte* paramsPtr = stackalloc byte[1100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 1096);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: CalculateSwingPath
    /// </summary>
    public unsafe bool CalculateSwingPath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo, System.Numerics.Vector3 DesiredStartLocation, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 StartVelocity, System.Numerics.Vector3 EndVelocity, float IdealSwingTime, float IdealSwingLength, float CheckSizeMod, out System.Numerics.Vector3 FirstHitLocation, bool bDebugDraw, bool bDrawPersistent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CalculateSwingPath", true);
        byte* paramsPtr = stackalloc byte[1180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredStartLocation, paramsPtr + 1096);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 1108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 1120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 1132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingTime, paramsPtr + 1144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingLength, paramsPtr + 1148);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckSizeMod, paramsPtr + 1152);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 1168);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 1172);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 1156);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 1176);
    }

    /// <summary>
    /// Struct: FClimbLedges
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FClimbLedges
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bDangleLedge
        /// </summary>
        public unsafe bool bDangleLedge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EClawClimbStartMode
    /// </summary>
    public enum EClawClimbStartMode
    {
        CCSM_FromGround = 0,
        CCSM_FromWallStick = 1,
        CCSM_FromSwing = 2,
        CCSM_FromShortSwing = 3,
        CCSM_MAX = 4,
    }

    /// <summary>
    /// Struct: FWallClimbInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 1096)]
    public partial record struct FWallClimbInfo
    {
        /// <summary>
        /// StructProperty: ClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath ClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bGotValidPath
        /// </summary>
        public unsafe bool bGotValidPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingCheckNewPath
        /// </summary>
        public unsafe bool bEdgeSwingCheckNewPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }; }
        }

        /// <summary>
        /// BoolProperty: bUsingFallbackPath
        /// </summary>
        public unsafe bool bUsingFallbackPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }; }
        }

        /// <summary>
        /// BoolProperty: bFromWallStick
        /// </summary>
        public unsafe bool bFromWallStick
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 212); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedEdgeSwingPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedEdgeSwingPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 213); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 213); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedAerialSwingPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedAerialSwingPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 214); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 214); }; }
        }

        /// <summary>
        /// BoolProperty: bLastFailedDueToPounceDistance
        /// </summary>
        public unsafe bool bLastFailedDueToPounceDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailReason
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.ClimbPathFailReason LastFailReason
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.ClimbPathFailReason>(Ptr + 220); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }; }
        }

        /// <summary>
        /// ByteProperty: LastSuccessfulPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastSuccessfulPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 221); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 221); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedStartPoint
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EStartPoints LastFailedStartPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EStartPoints>(Ptr + 222); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 222); }; }
        }

        /// <summary>
        /// StructProperty: LastCheckedAerialSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LastCheckedAerialSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }; }
        }

        /// <summary>
        /// StructProperty: InitialLocator
        /// </summary>
        public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator InitialLocator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 236); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }; }
        }

        /// <summary>
        /// StructProperty: LastValidGrapplePoint
        /// </summary>
        public unsafe System.IntPtr LastValidGrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }; }
        }

        /// <summary>
        /// ObjectProperty: LastValidHidePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint LastValidHidePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }; }
        }

        /// <summary>
        /// BoolProperty: bLastValidIsCeilingTarget
        /// </summary>
        public unsafe bool bLastValidIsCeilingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }; }
        }

        /// <summary>
        /// StructProperty: LastValidCeilingLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastValidCeilingLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 388); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }; }
        }

        /// <summary>
        /// StructProperty: WallNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 WallNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }; }
        }

        /// <summary>
        /// StructProperty: LastTargetLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastTargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 412); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }; }
        }

        /// <summary>
        /// StructProperty: LastTargetWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastTargetWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }; }
        }

        /// <summary>
        /// StructProperty: LastMaxRight
        /// </summary>
        public unsafe System.Numerics.Vector3 LastMaxRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 436); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }; }
        }

        /// <summary>
        /// StructProperty: LastMaxLeft
        /// </summary>
        public unsafe System.Numerics.Vector3 LastMaxLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }; }
        }

        /// <summary>
        /// StructProperty: LastGrappleRight
        /// </summary>
        public unsafe System.Numerics.Vector3 LastGrappleRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 460); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }; }
        }

        /// <summary>
        /// StructProperty: LastGrappleLeft
        /// </summary>
        public unsafe System.Numerics.Vector3 LastGrappleLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }; }
        }

        /// <summary>
        /// BoolProperty: bLastExtremeRight
        /// </summary>
        public unsafe bool bLastExtremeRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }; }
        }

        /// <summary>
        /// BoolProperty: bLastExtremeLeft
        /// </summary>
        public unsafe bool bLastExtremeLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }; }
        }

        /// <summary>
        /// StructProperty: EdgeSwingLaunchLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeSwingLaunchLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingPointCheckFailed
        /// </summary>
        public unsafe bool bEdgeSwingPointCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }; }
        }

        /// <summary>
        /// BoolProperty: bValidEdgeSwingTarget
        /// </summary>
        public unsafe bool bValidEdgeSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }; }
        }

        /// <summary>
        /// BoolProperty: bAerialSwingPointCheckFailed
        /// </summary>
        public unsafe bool bAerialSwingPointCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }; }
        }

        /// <summary>
        /// BoolProperty: bValidAerialSwingTarget
        /// </summary>
        public unsafe bool bValidAerialSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }; }
        }

        /// <summary>
        /// BoolProperty: bValidDirectPounceTarget
        /// </summary>
        public unsafe bool bValidDirectPounceTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }; }
        }

        /// <summary>
        /// BoolProperty: bValidWallClimbTarget
        /// </summary>
        public unsafe bool bValidWallClimbTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }; }
        }

        /// <summary>
        /// BoolProperty: bValidCeilingTarget
        /// </summary>
        public unsafe bool bValidCeilingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }; }
        }

        /// <summary>
        /// BoolProperty: bValidVantageSwingTarget
        /// </summary>
        public unsafe bool bValidVantageSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }; }
        }

        /// <summary>
        /// StructProperty: AssociatedGrapplePoint
        /// </summary>
        public unsafe System.IntPtr AssociatedGrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }; }
        }

        /// <summary>
        /// FloatProperty: AssociatedBonusScore
        /// </summary>
        public unsafe float AssociatedBonusScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedEdgeSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedEdgeSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 516); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedEdgeSwingWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedEdgeSwingWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedAerialSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedAerialSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 540); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }; }
        }

        /// <summary>
        /// StructProperty: PlayerStartLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 PlayerStartLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }; }
        }

        /// <summary>
        /// FloatProperty: SwingHeightOffset
        /// </summary>
        public unsafe float SwingHeightOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }; }
        }

        /// <summary>
        /// BoolProperty: bDebugNewPath
        /// </summary>
        public unsafe bool bDebugNewPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 568); }; }
        }

        /// <summary>
        /// StructProperty: InitialWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 572); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }; }
        }

        /// <summary>
        /// StructProperty: InitialLandLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialLandLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }; }
        }

        /// <summary>
        /// StructProperty: SwingParams
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SwingParams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(Ptr + 596); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }; }
        }

        /// <summary>
        /// StructProperty: LastFailedSwingLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastFailedSwingLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }; }
        }

        /// <summary>
        /// BoolProperty: bCheckedLPounceWall
        /// </summary>
        public unsafe bool bCheckedLPounceWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }; }
        }

        /// <summary>
        /// BoolProperty: bFoundLPounceWall
        /// </summary>
        public unsafe bool bFoundLPounceWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }; }
        }

        /// <summary>
        /// StructProperty: LPounceWallLocation
        /// </summary>
        public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator LPounceWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }; }
        }

        /// <summary>
        /// StructProperty: LastLPounceWallCheckPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastLPounceWallCheckPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 836); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }; }
        }

        /// <summary>
        /// BoolProperty: bFoundLPounceToTarget
        /// </summary>
        public unsafe bool bFoundLPounceToTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }; }
        }

        /// <summary>
        /// BoolProperty: bCheckedLPounceToTarget
        /// </summary>
        public unsafe bool bCheckedLPounceToTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }; }
        }

        /// <summary>
        /// StructProperty: LPounceToTargetLocation
        /// </summary>
        public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator LPounceToTargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 852); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }; }
        }

        /// <summary>
        /// StructProperty: LastLPounceTargetCheckPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastLPounceTargetCheckPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }; }
        }

        /// <summary>
        /// NameProperty: LastLPounceTargetCheckState
        /// </summary>
        public unsafe BmSDK.FName LastLPounceTargetCheckState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 996); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }; }
        }

        /// <summary>
        /// IntProperty: ArrayIndex
        /// </summary>
        public unsafe int ArrayIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }; }
        }

        /// <summary>
        /// StructProperty: GrapplePoint
        /// </summary>
        public unsafe System.IntPtr GrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }; }
        }

        /// <summary>
        /// ObjectProperty: HidePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint HidePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 1016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingPointNeedsCheck
        /// </summary>
        public unsafe bool bEdgeSwingPointNeedsCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingUseShortPounceOff
        /// </summary>
        public unsafe bool bEdgeSwingUseShortPounceOff
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }; }
        }

        /// <summary>
        /// BoolProperty: bAerialSwingPointNeedsCheck
        /// </summary>
        public unsafe bool bAerialSwingPointNeedsCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }; }
        }

        /// <summary>
        /// BoolProperty: bLastSwingCheckWasShortSwing
        /// </summary>
        public unsafe bool bLastSwingCheckWasShortSwing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }; }
        }

        /// <summary>
        /// StructProperty: DebugLastSwingStartLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 DebugLastSwingStartLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1028); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }; }
        }

        /// <summary>
        /// StructProperty: DebugLastSwingStartVel
        /// </summary>
        public unsafe System.Numerics.Vector3 DebugLastSwingStartVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }; }
        }

        /// <summary>
        /// FloatProperty: SwingStartTime
        /// </summary>
        public unsafe float SwingStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }; }
        }

        /// <summary>
        /// IntProperty: PathRetries
        /// </summary>
        public unsafe int PathRetries
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }; }
        }

        /// <summary>
        /// IntProperty: PathRecalcs
        /// </summary>
        public unsafe int PathRecalcs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }; }
        }

        /// <summary>
        /// StructProperty: ToGrappleLine
        /// </summary>
        public unsafe System.Numerics.Vector3 ToGrappleLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }; }
        }

        /// <summary>
        /// StructProperty: ToRight
        /// </summary>
        public unsafe System.Numerics.Vector3 ToRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1076); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }; }
        }

        /// <summary>
        /// ObjectProperty: ClimbLocator
        /// </summary>
        public unsafe BmSDK.BmGame.RClimbLocator ClimbLocator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RClimbLocator>(Ptr + 1088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }; }
        }
    }

    /// <summary>
    /// Struct: FSwingParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FSwingParameters
    {
        /// <summary>
        /// StructProperty: SwingStartLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingStartLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SwingStartTangent
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingStartTangent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: SwingEndLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingEndLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: SwingEndTangent
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingEndTangent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: SwingWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: SwingTime
        /// </summary>
        public unsafe float SwingTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: OneOverSwingTime
        /// </summary>
        public unsafe float OneOverSwingTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: ProportionAlongPath
        /// </summary>
        public unsafe float ProportionAlongPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: ProportionAtAnimationStart
        /// </summary>
        public unsafe float ProportionAtAnimationStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: IdealEndYaw
        /// </summary>
        public unsafe float IdealEndYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: IdealStartPitch
        /// </summary>
        public unsafe float IdealStartPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: IdealEndPitch
        /// </summary>
        public unsafe float IdealEndPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bUsed
        /// </summary>
        public unsafe bool bUsed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }; }
        }

        /// <summary>
        /// BoolProperty: bValid
        /// </summary>
        public unsafe bool bValid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Enum: ClimbPathFailReason
    /// </summary>
    public enum ClimbPathFailReason
    {
        CPFR_None = 0,
        CPFR_NoStartPoint = 1,
        CPFR_PouncesTooFar = 2,
        CPFR_ExceedingHorizontalPounce = 3,
        CPFR_MAX = 4,
    }

    /// <summary>
    /// Struct: FWallClimbPath
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public partial record struct FWallClimbPath
    {
        /// <summary>
        /// BoolProperty: bSearchedEdges
        /// </summary>
        public unsafe bool bSearchedEdges
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ClimbPoints
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallLandPoint> ClimbPoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallLandPoint>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bClimbToVantagePoint
        /// </summary>
        public unsafe bool bClimbToVantagePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: VantagePointActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor VantagePointActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bClimbToCeiling
        /// </summary>
        public unsafe bool bClimbToCeiling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: TargetLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: TargetNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: OriginalPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: TargetFeature
        /// </summary>
        public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator TargetFeature
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: NumClimbSteps
        /// </summary>
        public unsafe float NumClimbSteps
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }; }
        }
    }

    /// <summary>
    /// Struct: FWallLandPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 292)]
    public partial record struct FWallLandPoint
    {
        /// <summary>
        /// BoolProperty: bFoundEdge
        /// </summary>
        public unsafe bool bFoundEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bDangleEdge
        /// </summary>
        public unsafe bool bDangleEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: OriginalLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: OriginalNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: NextHoldLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 NextHoldLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: NextHoldNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 NextHoldNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bGotAnyEdge
        /// </summary>
        public unsafe bool bGotAnyEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// ByteProperty: InDir
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection InDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ByteProperty: OutDir
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection OutDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 81); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 81); }; }
        }

        /// <summary>
        /// StructProperty: CheckRefLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckRefLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// StructProperty: CheckStart
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// StructProperty: CheckEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// StructProperty: CheckExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// StructProperty: HitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 HitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckStart
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// StructProperty: FootHitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 FootHitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 180); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: FootCheckDone
        /// </summary>
        public unsafe bool FootCheckDone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 192); }; }
        }

        /// <summary>
        /// BoolProperty: FootCheckFailed
        /// </summary>
        public unsafe bool FootCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 192); }; }
        }

        /// <summary>
        /// StructProperty: SpotCheck
        /// </summary>
        public unsafe System.Numerics.Vector3 SpotCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// StructProperty: ToNextExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }

        /// <summary>
        /// StructProperty: ToNextStart
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 220); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }; }
        }

        /// <summary>
        /// StructProperty: ToNextEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }; }
        }

        /// <summary>
        /// StructProperty: Spot2Check
        /// </summary>
        public unsafe System.Numerics.Vector3 Spot2Check
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 244); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2Extent
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2Extent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2Start
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 268); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2End
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2End
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }; }
        }
    }

    /// <summary>
    /// Enum: EStartPoints
    /// </summary>
    public enum EStartPoints
    {
        START_NextToPlayer = 0,
        START_BelowTarget = 1,
        START_FarLeft = 2,
        START_FarRight = 3,
        START_Left = 4,
        START_Right = 5,
        START_VantageLeft = 6,
        START_VantageRight = 7,
        START_ClimbLocator = 8,
        START_ExtraPounceCheck = 9,
        START_Failed = 10,
        START_MAX = 11,
    }

    /// <summary>
    /// Enum: EClawClimbDirection
    /// </summary>
    public enum EClawClimbDirection
    {
        CCD_Random = 0,
        CCD_Left = 1,
        CCD_Center = 2,
        CCD_Right = 3,
        CCD_None = 4,
        CCD_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: PounceToLedgeHangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToLedgeHangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// ObjectProperty: PounceToLedgeDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToLedgeDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// ObjectProperty: PounceOntoRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOntoRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// ObjectProperty: PounceToVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbStartMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbStartMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3700); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallLand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallJumpOff
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallJumpOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3716); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndLedgeHang
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndLedgeHang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3724); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndLedgeDangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndLedgeDangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3732); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverLedgeStand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverLedgeStand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverLedgeRun
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverLedgeRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3748); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverRailingStand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverRailingStand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3756); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverRailingRun
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverRailingRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3764); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOnRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOnRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3772); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndVantagePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndVantagePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3780); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3788); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounce
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3796); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounceFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3804); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceClose
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounceClose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3812); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedClose
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedClose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3820); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3828); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargeted
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargeted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3836); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3852); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedFarSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedFarSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3860); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseWallStick
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseWallStick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3868); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseWallStickDangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseWallStickDangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3876); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3884); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3892); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedLeftFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedLeftFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedRightFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedRightFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 3908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3908); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3924); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortFromStealthMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortFromStealthMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3932); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingMoveWithAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingMoveWithAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWithAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWithAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWith180LAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWith180LAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3956); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWith180RAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWith180RAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// ObjectProperty: LockedEdgeSwingHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LockedEdgeSwingHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 3972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3972); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RWallClimbCamera WallClimbCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWallClimbCamera>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// ObjectProperty: LastCeilingClimbVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume LastCeilingClimbVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 3988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3988); }
    }

    /// <summary>
    /// ObjectProperty: LastPickedHidePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastPickedHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }

    /// <summary>
    /// ObjectProperty: GASSPLastHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GASSPLastHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// FloatProperty: CamSwitchTime
    /// </summary>
    public unsafe float CamSwitchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// FloatProperty: MaxWhipBoost2dRange
    /// </summary>
    public unsafe float MaxWhipBoost2dRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// BoolProperty: bDebugTargetModes
    /// </summary>
    public unsafe bool bDebugTargetModes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingPath
    /// </summary>
    public unsafe bool bDebugSwingPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugWallClimb
    /// </summary>
    public unsafe bool bDebugWallClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugWallClimbPersistent
    /// </summary>
    public unsafe bool bDebugWallClimbPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPath
    /// </summary>
    public unsafe bool bDebugDrawPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathPersistent
    /// </summary>
    public unsafe bool bDebugDrawPathPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathPounces
    /// </summary>
    public unsafe bool bDebugDrawPathPounces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathWallChecks
    /// </summary>
    public unsafe bool bDebugDrawPathWallChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawInitialTestPersistent
    /// </summary>
    public unsafe bool bDebugDrawInitialTestPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawCeilingChecks
    /// </summary>
    public unsafe bool bDebugDrawCeilingChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugForcePathRecalculation
    /// </summary>
    public unsafe bool bDebugForcePathRecalculation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceFallbackPath
    /// </summary>
    public unsafe bool bDebugForceFallbackPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwing
    /// </summary>
    public unsafe bool bDebugEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingLaunch
    /// </summary>
    public unsafe bool bDebugEdgeSwingLaunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingStartCheck
    /// </summary>
    public unsafe bool bDebugEdgeSwingStartCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingSkipFinalPounceCheck
    /// </summary>
    public unsafe bool bDebugEdgeSwingSkipFinalPounceCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugSkipInitialSwingHitCheck
    /// </summary>
    public unsafe bool bDebugSkipInitialSwingHitCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugShortEdgeSwing
    /// </summary>
    public unsafe bool bDebugShortEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugAerialSwing
    /// </summary>
    public unsafe bool bDebugAerialSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceIn
    /// </summary>
    public unsafe bool bDebugLongPounceIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceInDirectPounce
    /// </summary>
    public unsafe bool bDebugLongPounceInDirectPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceDraw
    /// </summary>
    public unsafe bool bDebugLongPounceDraw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugInitialPounceToWall
    /// </summary>
    public unsafe bool bDebugInitialPounceToWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugCheckWallStick
    /// </summary>
    public unsafe bool bDebugCheckWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugSkipInitialPathTest
    /// </summary>
    public unsafe bool bDebugSkipInitialPathTest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugSuppressGrapplePoints
    /// </summary>
    public unsafe bool bDebugSuppressGrapplePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugDelayedSwing
    /// </summary>
    public unsafe bool bDebugDelayedSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingStart
    /// </summary>
    public unsafe bool bDebugSwingStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawLinkedHidePoints
    /// </summary>
    public unsafe bool bDebugDrawLinkedHidePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugClimbLocators
    /// </summary>
    public unsafe bool bDebugClimbLocators
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugPounceTargetingIterations
    /// </summary>
    public unsafe bool bDebugPounceTargetingIterations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bDebugLocatorChainAlignment
    /// </summary>
    public unsafe bool bDebugLocatorChainAlignment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4020); }
    }

    /// <summary>
    /// BoolProperty: bEnableEdgeSwing
    /// </summary>
    public unsafe bool bEnableEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bEnableDelayedSwing
    /// </summary>
    public unsafe bool bEnableDelayedSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bAutoClimbFromWallStick
    /// </summary>
    public unsafe bool bAutoClimbFromWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bClimbUseLookAt
    /// </summary>
    public unsafe bool bClimbUseLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bClimbCamOverlay
    /// </summary>
    public unsafe bool bClimbCamOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bPawnAtSwingEdge
    /// </summary>
    public unsafe bool bPawnAtSwingEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bScaleLR
    /// </summary>
    public unsafe bool bScaleLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bScaleLRClampMin
    /// </summary>
    public unsafe bool bScaleLRClampMin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bScaleLRClampMax
    /// </summary>
    public unsafe bool bScaleLRClampMax
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bScaleUp
    /// </summary>
    public unsafe bool bScaleUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bClipLR
    /// </summary>
    public unsafe bool bClipLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bClipUp
    /// </summary>
    public unsafe bool bClipUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bFinalScaleLR
    /// </summary>
    public unsafe bool bFinalScaleLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bFinalScaleUp
    /// </summary>
    public unsafe bool bFinalScaleUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bFinalClipLR
    /// </summary>
    public unsafe bool bFinalClipLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bFinalClipUp
    /// </summary>
    public unsafe bool bFinalClipUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bOptimisePaths
    /// </summary>
    public unsafe bool bOptimisePaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bDebugVantageTrace
    /// </summary>
    public unsafe bool bDebugVantageTrace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bUseNewVantagePath
    /// </summary>
    public unsafe bool bUseNewVantagePath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceHoldOntoLedge
    /// </summary>
    public unsafe bool bDebugForceHoldOntoLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bLastCeilingCheckResult
    /// </summary>
    public unsafe bool bLastCeilingCheckResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredWhipImpactFX
    /// </summary>
    public unsafe bool bTriggeredWhipImpactFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bExtraPounceTargetIteration
    /// </summary>
    public unsafe bool bExtraPounceTargetIteration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bEnableSwingParamsCaching
    /// </summary>
    public unsafe bool bEnableSwingParamsCaching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// BoolProperty: bGASSPLastResult
    /// </summary>
    public unsafe bool bGASSPLastResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4024); }
    }

    /// <summary>
    /// FloatProperty: MinimumSwingTime
    /// </summary>
    public unsafe float MinimumSwingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// IntProperty: CurrentLandPointIndex
    /// </summary>
    public unsafe int CurrentLandPointIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4032); }
    }

    /// <summary>
    /// StructProperty: CurrentClimbInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo CurrentClimbInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }

    /// <summary>
    /// StructProperty: LastClimbInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo LastClimbInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }

    /// <summary>
    /// FloatProperty: LastClimbInfoTime
    /// </summary>
    public unsafe float LastClimbInfoTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6228); }
    }

    /// <summary>
    /// FloatProperty: LastClimbInfoDelay
    /// </summary>
    public unsafe float LastClimbInfoDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6232); }
    }

    /// <summary>
    /// ArrayProperty: WallClimbs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo> WallClimbs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>>(Ptr + 6236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6236); }
    }

    /// <summary>
    /// StructProperty: LastClimbLandLocator
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator LastClimbLandLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 6252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6252); }
    }

    /// <summary>
    /// StructProperty: LastWallLandLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastWallLandLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6384); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceToWall
    /// </summary>
    public unsafe float MaxDistanceToWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6396); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceToWallDirectPounce
    /// </summary>
    public unsafe float MaxDistanceToWallDirectPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6400); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceDistance
    /// </summary>
    public unsafe float MaxDirectPounceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6404); }
    }

    /// <summary>
    /// FloatProperty: MaxHDistanceToPouncePoints
    /// </summary>
    public unsafe float MaxHDistanceToPouncePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6408); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToVantagePoints
    /// </summary>
    public unsafe float MaxPounceHeightToVantagePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6412); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToVantagePointsHPH
    /// </summary>
    public unsafe float MaxPounceHeightToVantagePointsHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6416); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToLedges
    /// </summary>
    public unsafe float MaxPounceHeightToLedges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6420); }
    }

    /// <summary>
    /// FloatProperty: MinPounceHeightToLedges
    /// </summary>
    public unsafe float MinPounceHeightToLedges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6424); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceToWallDirectPounceHPH
    /// </summary>
    public unsafe float MaxDistanceToWallDirectPounceHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6428); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceDistanceHPH
    /// </summary>
    public unsafe float MaxDirectPounceDistanceHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6432); }
    }

    /// <summary>
    /// FloatProperty: MaxWallClimbCosRightAngle
    /// </summary>
    public unsafe float MaxWallClimbCosRightAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6436); }
    }

    /// <summary>
    /// FloatProperty: MinWallClimbMargin
    /// </summary>
    public unsafe float MinWallClimbMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }

    /// <summary>
    /// FloatProperty: MaxWallClimbWidth
    /// </summary>
    public unsafe float MaxWallClimbWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6444); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalWallPounce
    /// </summary>
    public unsafe float MaxHorizontalWallPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6448); }
    }

    /// <summary>
    /// FloatProperty: GrappleTargetEdgeMaxCos
    /// </summary>
    public unsafe float GrappleTargetEdgeMaxCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6452); }
    }

    /// <summary>
    /// FloatProperty: GrappleTargetNormalMaxCos
    /// </summary>
    public unsafe float GrappleTargetNormalMaxCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }

    /// <summary>
    /// FloatProperty: VantagePathWidth
    /// </summary>
    public unsafe float VantagePathWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }

    /// <summary>
    /// FloatProperty: VantagePathWidthNew
    /// </summary>
    public unsafe float VantagePathWidthNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6464); }
    }

    /// <summary>
    /// FloatProperty: MaxEdgeToAerialDelayTime
    /// </summary>
    public unsafe float MaxEdgeToAerialDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6468); }
    }

    /// <summary>
    /// FloatProperty: MaxAerialToAerialDelayTime
    /// </summary>
    public unsafe float MaxAerialToAerialDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6472); }
    }

    /// <summary>
    /// StructProperty: OriginalGrapplePoint
    /// </summary>
    public unsafe System.IntPtr OriginalGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }

    /// <summary>
    /// ByteProperty: ClawClimbStartMode
    /// </summary>
    public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbStartMode ClawClimbStartMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbStartMode>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }

    /// <summary>
    /// FloatProperty: CamOverlayStrength
    /// </summary>
    public unsafe float CamOverlayStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6488); }
    }

    /// <summary>
    /// StructProperty: LockedEdgeSwingGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo LockedEdgeSwingGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo>(Ptr + 6492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6492); }
    }

    /// <summary>
    /// StructProperty: LockedEdgeSwingGrappleTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 LockedEdgeSwingGrappleTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6572); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingLaunchLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 EdgeSwingLaunchLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6584); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingStartLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 EdgeSwingStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6596); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingEndLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 EdgeSwingEndLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6608); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingWallLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 EdgeSwingWallLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6620); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingWallNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 EdgeSwingWallNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6632); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo EdgeSwingGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint.FGrapplePointInfo>(Ptr + 6644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6644); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingGrappleTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 EdgeSwingGrappleTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6724); }
    }

    /// <summary>
    /// StructProperty: SwingLaunchVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 SwingLaunchVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// StructProperty: SwingLaunchShortVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 SwingLaunchShortVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6748); }
    }

    /// <summary>
    /// StructProperty: SwingLaunchOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 SwingLaunchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// StructProperty: SwingLaunchShortOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 SwingLaunchShortOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingLaunchCheckExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 EdgeSwingLaunchCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6784); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingLaunchCheckShift
    /// </summary>
    public unsafe float EdgeSwingLaunchCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }

    /// <summary>
    /// FloatProperty: SwingStartIdealZTolerance
    /// </summary>
    public unsafe float SwingStartIdealZTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6800); }
    }

    /// <summary>
    /// FloatProperty: SwingStartMaxZAbovePlayerTolerance
    /// </summary>
    public unsafe float SwingStartMaxZAbovePlayerTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6804); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingGrappleTargetPitch
    /// </summary>
    public unsafe float EdgeSwingGrappleTargetPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingExtraFallFactor
    /// </summary>
    public unsafe float EdgeSwingExtraFallFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeSwingDistance
    /// </summary>
    public unsafe float MinEdgeSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6816); }
    }

    /// <summary>
    /// FloatProperty: MaxEdgeSwingTan
    /// </summary>
    public unsafe float MaxEdgeSwingTan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6820); }
    }

    /// <summary>
    /// FloatProperty: CloseSwingDistance
    /// </summary>
    public unsafe float CloseSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceForAimedEdgeSwingGrapple
    /// </summary>
    public unsafe float MaxDistanceForAimedEdgeSwingGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }

    /// <summary>
    /// FloatProperty: MinSwingWallLandToGrappleDistance
    /// </summary>
    public unsafe float MinSwingWallLandToGrappleDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeShortSwingHeight
    /// </summary>
    public unsafe float MinEdgeShortSwingHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6836); }
    }

    /// <summary>
    /// FloatProperty: EdgeShortSwingHDistThreshold
    /// </summary>
    public unsafe float EdgeShortSwingHDistThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// FloatProperty: ForceShortPounceOffHThreshold
    /// </summary>
    public unsafe float ForceShortPounceOffHThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6844); }
    }

    /// <summary>
    /// FloatProperty: ForceShortPounceOffZThreshold
    /// </summary>
    public unsafe float ForceShortPounceOffZThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// FloatProperty: MinAerialSwingDistance
    /// </summary>
    public unsafe float MinAerialSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetCloseRange
    /// </summary>
    public unsafe float AerialSwingTargetCloseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetMaxExtraDrop
    /// </summary>
    public unsafe float AerialSwingTargetMaxExtraDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetDropPerMs
    /// </summary>
    public unsafe float AerialSwingTargetDropPerMs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }

    /// <summary>
    /// FloatProperty: MaxSwingWallTargetHeight
    /// </summary>
    public unsafe float MaxSwingWallTargetHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6868); }
    }

    /// <summary>
    /// FloatProperty: MaxSwingHeightOffset
    /// </summary>
    public unsafe float MaxSwingHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6872); }
    }

    /// <summary>
    /// FloatProperty: MinSwingHeightOffset
    /// </summary>
    public unsafe float MinSwingHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6876); }
    }

    /// <summary>
    /// FloatProperty: ClimbStartPointExtraDistance
    /// </summary>
    public unsafe float ClimbStartPointExtraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// StructProperty: SecondLastPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 SecondLastPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6884); }
    }

    /// <summary>
    /// StructProperty: LastPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 LastPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6896); }
    }

    /// <summary>
    /// FloatProperty: WallCheckOut
    /// </summary>
    public unsafe float WallCheckOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6908); }
    }

    /// <summary>
    /// FloatProperty: WallCheckIn
    /// </summary>
    public unsafe float WallCheckIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6912); }
    }

    /// <summary>
    /// FloatProperty: WallCheckInVantage
    /// </summary>
    public unsafe float WallCheckInVantage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6916); }
    }

    /// <summary>
    /// FloatProperty: MaxWallOut
    /// </summary>
    public unsafe float MaxWallOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6920); }
    }

    /// <summary>
    /// StructProperty: PlayerCheckExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 PlayerCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6924); }
    }

    /// <summary>
    /// StructProperty: WallCheckExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 WallCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6936); }
    }

    /// <summary>
    /// StructProperty: WallCheckShift
    /// </summary>
    public unsafe System.Numerics.Vector3 WallCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6948); }
    }

    /// <summary>
    /// StructProperty: WallFootCheckExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 WallFootCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }

    /// <summary>
    /// StructProperty: WallFootCheckShift
    /// </summary>
    public unsafe System.Numerics.Vector3 WallFootCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6972); }
    }

    /// <summary>
    /// FloatProperty: WallHandToFootCheckZDiff
    /// </summary>
    public unsafe float WallHandToFootCheckZDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }

    /// <summary>
    /// FloatProperty: WallHandsToFeetInTolerance
    /// </summary>
    public unsafe float WallHandsToFeetInTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6988); }
    }

    /// <summary>
    /// FloatProperty: AlongWallCheckDistance
    /// </summary>
    public unsafe float AlongWallCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6992); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraEndOutOfWallDist
    /// </summary>
    public unsafe float AlongWallExtraEndOutOfWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6996); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraStartOutOfWallDist
    /// </summary>
    public unsafe float AlongWallExtraStartOutOfWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7000); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraEndIntoWallDist
    /// </summary>
    public unsafe float AlongWallExtraEndIntoWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7004); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraStartIntoWallDist
    /// </summary>
    public unsafe float AlongWallExtraStartIntoWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7008); }
    }

    /// <summary>
    /// FloatProperty: EdgeLocationCheckDistance
    /// </summary>
    public unsafe float EdgeLocationCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7012); }
    }

    /// <summary>
    /// FloatProperty: GrappleCheckOut
    /// </summary>
    public unsafe float GrappleCheckOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7016); }
    }

    /// <summary>
    /// StructProperty: PounceToGrappleCheckExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 PounceToGrappleCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7020); }
    }

    /// <summary>
    /// FloatProperty: MaxWallStickHidePointInDiff
    /// </summary>
    public unsafe float MaxWallStickHidePointInDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7032); }
    }

    /// <summary>
    /// FloatProperty: MaxWallStickHidePointOutDiff
    /// </summary>
    public unsafe float MaxWallStickHidePointOutDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7036); }
    }

    /// <summary>
    /// FloatProperty: MaxRunningEdgeSwingCheckRange
    /// </summary>
    public unsafe float MaxRunningEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7040); }
    }

    /// <summary>
    /// FloatProperty: MinRunningEdgeSwingCheckRange
    /// </summary>
    public unsafe float MinRunningEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7044); }
    }

    /// <summary>
    /// FloatProperty: MaxStandingEdgeSwingCheckRange
    /// </summary>
    public unsafe float MaxStandingEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7048); }
    }

    /// <summary>
    /// FloatProperty: MinStandingEdgeSwingCheckRange
    /// </summary>
    public unsafe float MinStandingEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7052); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingCheckRangeSteps
    /// </summary>
    public unsafe float EdgeSwingCheckRangeSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7056); }
    }

    /// <summary>
    /// FloatProperty: SwingJumpToWallPitch
    /// </summary>
    public unsafe float SwingJumpToWallPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7060); }
    }

    /// <summary>
    /// FloatProperty: SwingJumpToWallSpeed
    /// </summary>
    public unsafe float SwingJumpToWallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7064); }
    }

    /// <summary>
    /// FloatProperty: FirstClimbStepToCeiling
    /// </summary>
    public unsafe float FirstClimbStepToCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7068); }
    }

    /// <summary>
    /// StructProperty: CeilingSpaceCheckExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 CeilingSpaceCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7072); }
    }

    /// <summary>
    /// FloatProperty: CeilingTraceHeight
    /// </summary>
    public unsafe float CeilingTraceHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7084); }
    }

    /// <summary>
    /// FloatProperty: MinLRDist
    /// </summary>
    public unsafe float MinLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7088); }
    }

    /// <summary>
    /// FloatProperty: MaxLRDist
    /// </summary>
    public unsafe float MaxLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7092); }
    }

    /// <summary>
    /// FloatProperty: MinLRScale
    /// </summary>
    public unsafe float MinLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7096); }
    }

    /// <summary>
    /// FloatProperty: MaxLRScale
    /// </summary>
    public unsafe float MaxLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7100); }
    }

    /// <summary>
    /// FloatProperty: LRScale
    /// </summary>
    public unsafe float LRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7104); }
    }

    /// <summary>
    /// FloatProperty: MinUpDist
    /// </summary>
    public unsafe float MinUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7108); }
    }

    /// <summary>
    /// FloatProperty: MaxUpDist
    /// </summary>
    public unsafe float MaxUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7112); }
    }

    /// <summary>
    /// FloatProperty: MinUpScale
    /// </summary>
    public unsafe float MinUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7116); }
    }

    /// <summary>
    /// FloatProperty: MaxUpScale
    /// </summary>
    public unsafe float MaxUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7120); }
    }

    /// <summary>
    /// FloatProperty: UpScale
    /// </summary>
    public unsafe float UpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7124); }
    }

    /// <summary>
    /// FloatProperty: ClipLRIdealDist
    /// </summary>
    public unsafe float ClipLRIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7128); }
    }

    /// <summary>
    /// FloatProperty: ClipLRPer100
    /// </summary>
    public unsafe float ClipLRPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7132); }
    }

    /// <summary>
    /// FloatProperty: ClipLRMaxTime
    /// </summary>
    public unsafe float ClipLRMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7136); }
    }

    /// <summary>
    /// FloatProperty: ClipUpIdealDist
    /// </summary>
    public unsafe float ClipUpIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7140); }
    }

    /// <summary>
    /// FloatProperty: ClipUpPer100
    /// </summary>
    public unsafe float ClipUpPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7144); }
    }

    /// <summary>
    /// FloatProperty: ClipUpMaxTime
    /// </summary>
    public unsafe float ClipUpMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }

    /// <summary>
    /// FloatProperty: FinalMinLRDist
    /// </summary>
    public unsafe float FinalMinLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7152); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxLRDist
    /// </summary>
    public unsafe float FinalMaxLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7156); }
    }

    /// <summary>
    /// FloatProperty: FinalMinLRScale
    /// </summary>
    public unsafe float FinalMinLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxLRScale
    /// </summary>
    public unsafe float FinalMaxLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7164); }
    }

    /// <summary>
    /// FloatProperty: FinalLRScale
    /// </summary>
    public unsafe float FinalLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// FloatProperty: FinalMinUpDist
    /// </summary>
    public unsafe float FinalMinUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7172); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxUpDist
    /// </summary>
    public unsafe float FinalMaxUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7176); }
    }

    /// <summary>
    /// FloatProperty: FinalMinUpScale
    /// </summary>
    public unsafe float FinalMinUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7180); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxUpScale
    /// </summary>
    public unsafe float FinalMaxUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7184); }
    }

    /// <summary>
    /// FloatProperty: FinalUpScale
    /// </summary>
    public unsafe float FinalUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRIdealDist
    /// </summary>
    public unsafe float FinalClipLRIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7192); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRPer100
    /// </summary>
    public unsafe float FinalClipLRPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7196); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRMaxTime
    /// </summary>
    public unsafe float FinalClipLRMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7200); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpIdealDist
    /// </summary>
    public unsafe float FinalClipUpIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpPer100
    /// </summary>
    public unsafe float FinalClipUpPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7208); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpMaxTime
    /// </summary>
    public unsafe float FinalClipUpMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7212); }
    }

    /// <summary>
    /// FloatProperty: PounceDelay
    /// </summary>
    public unsafe float PounceDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7216); }
    }

    /// <summary>
    /// FloatProperty: EdgeVUpTolerancePercentage
    /// </summary>
    public unsafe float EdgeVUpTolerancePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7220); }
    }

    /// <summary>
    /// FloatProperty: EdgeVDownTolerancePercentage
    /// </summary>
    public unsafe float EdgeVDownTolerancePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7224); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeVDistance
    /// </summary>
    public unsafe float MinEdgeVDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7228); }
    }

    /// <summary>
    /// FloatProperty: MaxAerialTargetingAngle
    /// </summary>
    public unsafe float MaxAerialTargetingAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7232); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceSide
    /// </summary>
    public unsafe float VantageWallTraceSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7236); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceDown
    /// </summary>
    public unsafe float VantageWallTraceDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7240); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceOut
    /// </summary>
    public unsafe float VantageWallTraceOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7244); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceIn
    /// </summary>
    public unsafe float VantageWallTraceIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7248); }
    }

    /// <summary>
    /// FloatProperty: VantagePathMinDistance
    /// </summary>
    public unsafe float VantagePathMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7252); }
    }

    /// <summary>
    /// StructProperty: LastCeilingCheckLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastCeilingCheckLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7256); }
    }

    /// <summary>
    /// StructProperty: LastCeilingCheckTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 LastCeilingCheckTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7268); }
    }

    /// <summary>
    /// FloatProperty: LastCeilingCheckFrame
    /// </summary>
    public unsafe float LastCeilingCheckFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7280); }
    }

    /// <summary>
    /// StructProperty: InitialPounceToWallCheckExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 InitialPounceToWallCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7284); }
    }

    /// <summary>
    /// IntProperty: NumPounceItersPerUpdate
    /// </summary>
    public unsafe int NumPounceItersPerUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7296); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecks
    /// </summary>
    public unsafe int MaxPounceSingleLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7300); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecksCoherency
    /// </summary>
    public unsafe int MaxPounceSingleLineChecksCoherency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7304); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecksLowPrio
    /// </summary>
    public unsafe int MaxPounceSingleLineChecksLowPrio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7308); }
    }

    /// <summary>
    /// IntProperty: MaxFullPounceIters
    /// </summary>
    public unsafe int MaxFullPounceIters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7312); }
    }

    /// <summary>
    /// IntProperty: PounceSingleLineChecks
    /// </summary>
    public unsafe int PounceSingleLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7316); }
    }

    /// <summary>
    /// IntProperty: PounceSingleLineChecksTotal
    /// </summary>
    public unsafe int PounceSingleLineChecksTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7320); }
    }

    /// <summary>
    /// FloatProperty: LastPounceSingleLineCheck
    /// </summary>
    public unsafe float LastPounceSingleLineCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7324); }
    }

    /// <summary>
    /// FloatProperty: SwingStartCheckTime
    /// </summary>
    public unsafe float SwingStartCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7328); }
    }

    /// <summary>
    /// IntProperty: SwingStartCheckIterations
    /// </summary>
    public unsafe int SwingStartCheckIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7332); }
    }

    /// <summary>
    /// IntProperty: MaxSwingPathChecks
    /// </summary>
    public unsafe int MaxSwingPathChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7336); }
    }

    /// <summary>
    /// IntProperty: MinSwingPathChecks
    /// </summary>
    public unsafe int MinSwingPathChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7340); }
    }

    /// <summary>
    /// FloatProperty: SwingPathCheckUnits
    /// </summary>
    public unsafe float SwingPathCheckUnits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7344); }
    }

    /// <summary>
    /// IntProperty: SwingLineChecks
    /// </summary>
    public unsafe int SwingLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7348); }
    }

    /// <summary>
    /// IntProperty: SwingLineChecksTotal
    /// </summary>
    public unsafe int SwingLineChecksTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7352); }
    }

    /// <summary>
    /// FloatProperty: LastSwingLineCheck
    /// </summary>
    public unsafe float LastSwingLineCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7356); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecks
    /// </summary>
    public unsafe int MaxSwingLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7360); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecksCoherency
    /// </summary>
    public unsafe int MaxSwingLineChecksCoherency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7364); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecksLowPrio
    /// </summary>
    public unsafe int MaxSwingLineChecksLowPrio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7368); }
    }

    /// <summary>
    /// StructProperty: LastPickedGrapplePoint
    /// </summary>
    public unsafe System.IntPtr LastPickedGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7372); }
    }

    /// <summary>
    /// StructProperty: GASSPLastGrapplePoint
    /// </summary>
    public unsafe System.IntPtr GASSPLastGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7380); }
    }

    /// <summary>
    /// StructProperty: GASSPLastPlayerLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 GASSPLastPlayerLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7388); }
    }

    /// <summary>
    /// StructProperty: GASSPLastPlayerVel
    /// </summary>
    public unsafe System.Numerics.Vector3 GASSPLastPlayerVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7400); }
    }

    /// <summary>
    /// FloatProperty: GASSPLastSwingStartTime
    /// </summary>
    public unsafe float GASSPLastSwingStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7412); }
    }

    /// <summary>
    /// StructProperty: GASSPLastOrigin
    /// </summary>
    public unsafe System.Numerics.Vector3 GASSPLastOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7416); }
    }

    /// <summary>
    /// StructProperty: GASSPLastStartVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 GASSPLastStartVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7428); }
    }
}

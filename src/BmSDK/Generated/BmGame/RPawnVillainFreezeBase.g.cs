#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainFreezeBase<br/>
/// (size = 3600)
/// (flags = 144703670)
/// </summary>
public partial class RPawnVillainFreezeBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainFreezeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainFreezeBase.
    /// </summary>
    public static RPawnVillainFreezeBase DefaultObject => (RPawnVillainFreezeBase)StaticClass().DefaultObject;

    internal RPawnVillainFreezeBase() { }

    /// <summary>
    /// Constructs a new RPawnVillainFreezeBase
    /// </summary>
    public RPawnVillainFreezeBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainFreezeBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainFreezeBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreezeBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreezeBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreezeBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreezeBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreezeBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreezeBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreezeBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreezeBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetParameterInterference
    /// </summary>
    public unsafe override BmSDK.Engine.AkParameterName GetParameterInterference()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.GetParameterInterference", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetParameterAngle
    /// </summary>
    public unsafe override BmSDK.Engine.AkParameterName GetParameterAngle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.GetParameterAngle", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldAutoClimbAfterGrapple
    /// </summary>
    public unsafe virtual bool ShouldAutoClimbAfterGrapple(System.Numerics.Vector3 ClimbLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.ShouldAutoClimbAfterGrapple", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClimbLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: CanOpenBackScreen
    /// </summary>
    public unsafe virtual bool CanOpenBackScreen()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.CanOpenBackScreen", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HitByFreezeCluster
    /// </summary>
    public unsafe virtual void HitByFreezeCluster(System.Numerics.Vector3 ClusterLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.HitByFreezeCluster", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClusterLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitByFreezeBlast
    /// </summary>
    public unsafe virtual void HitByFreezeBlast()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.HitByFreezeBlast", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitByJammerGadgetCharge
    /// </summary>
    public unsafe virtual void HitByJammerGadgetCharge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.HitByJammerGadgetCharge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsVulnerableToJammerGadget
    /// </summary>
    public unsafe virtual bool IsVulnerableToJammerGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.IsVulnerableToJammerGadget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsVulnerableToBossStrike
    /// </summary>
    public unsafe virtual bool IsVulnerableToBossStrike()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.IsVulnerableToBossStrike", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMagneticBlastDuration
    /// </summary>
    public unsafe virtual float GetMagneticBlastDuration()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.GetMagneticBlastDuration", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TickMagneticBlast
    /// </summary>
    public unsafe virtual void TickMagneticBlast(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.TickMagneticBlast", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoMagneticBlastAttract
    /// </summary>
    public unsafe virtual void DoMagneticBlastAttract(System.Numerics.Vector3 magnet_source, BmSDK.Rotator wall_normal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.DoMagneticBlastAttract", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(magnet_source, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(wall_normal, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RespondToLineLauncher
    /// </summary>
    public unsafe virtual void RespondToLineLauncher(System.Numerics.Vector3 batmans_position, bool be_knocked_down)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.RespondToLineLauncher", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(batmans_position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(be_knocked_down, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AdjustGlideKickZ
    /// </summary>
    public unsafe override float AdjustGlideKickZ()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.AdjustGlideKickZ", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: KickedByBatman
    /// </summary>
    public unsafe virtual void KickedByBatman(System.Numerics.Vector3 batman_origin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.KickedByBatman", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(batman_origin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitWithGooMineEnhanced
    /// </summary>
    public unsafe virtual void HitWithGooMineEnhanced(System.Numerics.Vector3 goo_origin, bool is_glass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.HitWithGooMineEnhanced", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(goo_origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_glass, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StunPush
    /// </summary>
    public unsafe virtual bool StunPush(System.Numerics.Vector3 goo_origin, float OrientationProportion = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.StunPush", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(goo_origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrientationProportion, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: StunPull
    /// </summary>
    public unsafe virtual bool StunPull(System.Numerics.Vector3 harpoon_origin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.StunPull", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(harpoon_origin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SuspendBehaviour
    /// </summary>
    public unsafe virtual void SuspendBehaviour(bool OnlyIfNoVisualContact = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.SuspendBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyIfNoVisualContact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LineLauncherSuspendBehaviour
    /// </summary>
    public unsafe virtual void LineLauncherSuspendBehaviour(bool OnlyIfNoVisualContact = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.LineLauncherSuspendBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyIfNoVisualContact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Electrify
    /// </summary>
    public unsafe virtual void Electrify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.Electrify", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeKnockedDown
    /// </summary>
    public unsafe virtual bool CanBeKnockedDown(BmSDK.FString takedown = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.CanBeKnockedDown", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ShouldStopControllableBatarang
    /// </summary>
    public unsafe override bool ShouldStopControllableBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.ShouldStopControllableBatarang", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BatmanEntersVent
    /// </summary>
    public unsafe virtual void BatmanEntersVent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.BatmanEntersVent", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AlertToBrokenGlassSound
    /// </summary>
    public unsafe virtual void AlertToBrokenGlassSound(System.Numerics.Vector3 BreakageLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.AlertToBrokenGlassSound", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakageLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerDropFromIcyLedge
    /// </summary>
    public unsafe virtual void TriggerDropFromIcyLedge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.TriggerDropFromIcyLedge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerFailedGlideMove
    /// </summary>
    public unsafe virtual void TriggerFailedGlideMove(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.TriggerFailedGlideMove", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnVillainFreezeBase.Initialise", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: iHitsLanded
    /// </summary>
    public unsafe int iHitsLanded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// BoolProperty: bRepelAttackActive
    /// </summary>
    public unsafe bool bRepelAttackActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3564); }
    }

    /// <summary>
    /// BoolProperty: bRearRepelActive
    /// </summary>
    public unsafe bool bRearRepelActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3564); }
    }

    /// <summary>
    /// StrProperty: sMostRecentTakedownQuery
    /// </summary>
    public unsafe BmSDK.FString sMostRecentTakedownQuery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// IntProperty: iInitialHealth
    /// </summary>
    public unsafe int iInitialHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// IntProperty: StrikesBeforeFinal
    /// </summary>
    public unsafe int StrikesBeforeFinal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ObjectProperty: FreezeGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FreezeGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// ObjectProperty: FreezeFailedGlideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FreezeFailedGlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// FloatProperty: MagneticSurfaceRecoveryTime
    /// </summary>
    public unsafe float MagneticSurfaceRecoveryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3596); }
    }
}

#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CwJump<br/>
/// (size = 520)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CwJump : BmSDK.BmGame.RSpecialMoveConfig_RunningRelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CwJump", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CwJump() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CwJump
    /// </summary>
    public RSpecialMoveConfig_CwJump(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CwJump Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CwJump(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: CheckFreeJumpSpace
    /// </summary>
    public unsafe bool CheckFreeJumpSpace(BmSDK.BmGame.RPawnPlayer Player, BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveConfig_CwJump.CheckFreeJumpSpace", true);
        byte* paramsPtr = stackalloc byte[380];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 140);
    }

    /// <summary>
    /// Function: UpdateLocator
    /// </summary>
    public unsafe void UpdateLocator(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc, BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveConfig_CwJump.UpdateLocator", true);
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 132);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GetAnimSet(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveConfig_CwJump.GetAnimSet", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetFreeRotation
    /// </summary>
    public unsafe BmSDK.Rotator GetFreeRotation(BmSDK.BmGame.RPlayerController Controller, BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveConfig_CwJump.GetFreeRotation", true);
        byte* paramsPtr = stackalloc byte[172];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 140);
    }

    /// <summary>
    /// Enum: ECwJumpMoveExtraInfo
    /// </summary>
    public enum ECwJumpMoveExtraInfo
    {
        ECWJEI_FreeRotation = 0,
        ECWJEI_ExtraVelocity = 1,
        ECWJEI_CatwomanPitchRotation = 2,
        ECWJEI_MAX = 3,
    }

    /// <summary>
    /// BoolProperty: bAlignWithFeature
    /// </summary>
    public unsafe bool bAlignWithFeature
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bDisableCapeGlide
    /// </summary>
    public unsafe bool bDisableCapeGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bAllowModifyJumpDirection
    /// </summary>
    public unsafe bool bAllowModifyJumpDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bAllowLongPounceIn
    /// </summary>
    public unsafe bool bAllowLongPounceIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// NameProperty: StandToLaunchPounceAnim
    /// </summary>
    public unsafe BmSDK.FName StandToLaunchPounceAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: JumpOffSpeed
    /// </summary>
    public unsafe float JumpOffSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: JumpOffAngle
    /// </summary>
    public unsafe float JumpOffAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
}

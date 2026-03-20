#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_JokerBossTwoface<br/>
/// (size = 712)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_JokerBossTwoface : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_JokerBossTwoface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_JokerBossTwoface() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_JokerBossTwoface
    /// </summary>
    public RBMBehaviour_JokerBossTwoface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_JokerBossTwoface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_JokerBossTwoface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: EndCameraZoom
    /// </summary>
    public unsafe void EndCameraZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.EndCameraZoom", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowShootInZoom
    /// </summary>
    public unsafe void AllowShootInZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.AllowShootInZoom", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartCameraZoom
    /// </summary>
    public unsafe void StartCameraZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.StartCameraZoom", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShotJoker
    /// </summary>
    public unsafe void ShotJoker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.ShotJoker", true);
        byte* paramsPtr = stackalloc byte[196];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShotByJoker
    /// </summary>
    public unsafe void ShotByJoker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.ShotByJoker", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: JokerGunFired
    /// </summary>
    public unsafe void JokerGunFired()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.JokerGunFired", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSeeJoker
    /// </summary>
    public unsafe bool CanSeeJoker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.CanSeeJoker", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TwoFaceTalkingOver
    /// </summary>
    public unsafe void TwoFaceTalkingOver()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.TwoFaceTalkingOver", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetJokerDist
    /// </summary>
    public unsafe float GetJokerDist()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossTwoface.GetJokerDist", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: RefPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor RefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: TwofaceAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TwofaceAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: Joker
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Joker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: Pistol
    /// </summary>
    public unsafe BmSDK.BmGame.RSkeletalMeshActor Pistol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkeletalMeshActor>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: UpdateAction
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_TwoFaceLairController UpdateAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_TwoFaceLairController>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: JokerKnockBackMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig JokerKnockBackMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// NameProperty: IntroAnimName
    /// </summary>
    public unsafe BmSDK.FName IntroAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// NameProperty: TalkAnimName
    /// </summary>
    public unsafe BmSDK.FName TalkAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// NameProperty: AimAnimName
    /// </summary>
    public unsafe BmSDK.FName AimAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// NameProperty: AimFastAnimName
    /// </summary>
    public unsafe BmSDK.FName AimFastAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// NameProperty: AimIdleAnimName
    /// </summary>
    public unsafe BmSDK.FName AimIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: ShootAnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ShootAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// FloatProperty: TimeNotShooting
    /// </summary>
    public unsafe float TimeNotShooting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: TimeToShoot
    /// </summary>
    public unsafe float TimeToShoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: JokerTooCloseDistance
    /// </summary>
    public unsafe float JokerTooCloseDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: JokerCloseForAimDistance
    /// </summary>
    public unsafe float JokerCloseForAimDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bInCameraZoom
    /// </summary>
    public unsafe bool bInCameraZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }
}

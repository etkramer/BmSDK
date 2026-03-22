#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_JokerTauntAndTrack<br/>
/// (size = 404)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_JokerTauntAndTrack : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_JokerTauntAndTrack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_JokerTauntAndTrack() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_JokerTauntAndTrack
    /// </summary>
    public RBMBehaviour_JokerTauntAndTrack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_JokerTauntAndTrack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_JokerTauntAndTrack(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: PlayTurnStep
    /// </summary>
    public unsafe virtual void PlayTurnStep(System.Numerics.Vector3 TargetHeading)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerTauntAndTrack.PlayTurnStep", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetHeading, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerTauntAndTrack.Tick", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe override bool AwareOfPlayer(BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerTauntAndTrack.AwareOfPlayer", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerTauntAndTrack.OnActivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// StructProperty: TurnID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TurnID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}

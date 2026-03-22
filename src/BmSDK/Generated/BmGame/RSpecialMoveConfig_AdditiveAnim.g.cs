#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_AdditiveAnim<br/>
/// (size = 304)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_AdditiveAnim : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_AdditiveAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_AdditiveAnim() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_AdditiveAnim
    /// </summary>
    public RSpecialMoveConfig_AdditiveAnim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_AdditiveAnim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_AdditiveAnim(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.RPlayerController Controller, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation, bool ForceReplicateToClient = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveConfig_AdditiveAnim.TriggerSpecialMove", true);
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Controller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReplicateToClient, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// NameProperty: AnimName
    /// </summary>
    public unsafe BmSDK.FName AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
}

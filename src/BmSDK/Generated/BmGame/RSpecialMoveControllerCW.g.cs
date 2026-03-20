#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveControllerCW<br/>
/// (size = 104)
/// (flags = 136319122)
/// </summary>
public partial class RSpecialMoveControllerCW : BmSDK.BmGame.RSpecialMoveController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveControllerCW", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveControllerCW() { }

    /// <summary>
    /// Constructs a new RSpecialMoveControllerCW
    /// </summary>
    public RSpecialMoveControllerCW(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveControllerCW Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveControllerCW(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FindBestSpecialMove
    /// </summary>
    public unsafe override BmSDK.BmGame.RSpecialMoveConfig FindBestSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Feature, BmSDK.Engine.Pawn Instigator, float DeltaTime, BmSDK.Rotator CheckDirection, System.Numerics.Vector3 StickDir = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveControllerCW.FindBestSpecialMove", true);
        byte* paramsPtr = stackalloc byte[176];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Feature, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDirection, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StickDir, paramsPtr + 156);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 168);
    }
}

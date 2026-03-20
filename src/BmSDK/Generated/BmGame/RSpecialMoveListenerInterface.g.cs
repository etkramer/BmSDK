#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveListenerInterface<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveListenerInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveListenerInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveListenerInterface() { }

    /// <summary>
    /// Constructs a new RSpecialMoveListenerInterface
    /// </summary>
    public RSpecialMoveListenerInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveListenerInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveListenerInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SpecialMoveFinished
    /// </summary>
    public unsafe void SpecialMoveFinished(BmSDK.BmGame.RSpecialMoveInstance MoveFinishing, BmSDK.BmGame.RPawnPlayer Pawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveListenerInterface.SpecialMoveFinished", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveFinishing, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}

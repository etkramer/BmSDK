#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_MatineeSequenceSkipperBase<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_MatineeSequenceSkipperBase : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_MatineeSequenceSkipperBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_MatineeSequenceSkipperBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_MatineeSequenceSkipperBase
    /// </summary>
    public RSeqAct_MatineeSequenceSkipperBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_MatineeSequenceSkipperBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_MatineeSequenceSkipperBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ForwardMatineeToPosition
    /// </summary>
    public unsafe void ForwardMatineeToPosition(BmSDK.Engine.SeqAct_Interp Matinee, float NewPosition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_MatineeSequenceSkipperBase.ForwardMatineeToPosition", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Matinee, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 8);
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
}

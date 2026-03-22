#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_SetCustomHangMove<br/>
/// (size = 224)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_SetCustomHangMove : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_SetCustomHangMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetCustomHangMove() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetCustomHangMove
    /// </summary>
    public RSeqAct_SetCustomHangMove(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetCustomHangMove Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetCustomHangMove(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SetCustomHangMove.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: SpecialMov
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SpecialMov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// NameProperty: CustomHangCamera
    /// </summary>
    public unsafe BmSDK.FName CustomHangCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bCanShimmy
    /// </summary>
    public unsafe bool bCanShimmy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }
}

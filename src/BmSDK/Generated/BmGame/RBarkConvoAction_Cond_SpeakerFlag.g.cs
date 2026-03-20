#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_Cond_SpeakerFlag<br/>
/// (flags = 0)
/// </summary>
public partial class RBarkConvoAction_Cond_SpeakerFlag : BmSDK.BmGame.RBarkConvoActionCond, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction_Cond_SpeakerFlag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoAction_Cond_SpeakerFlag() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction_Cond_SpeakerFlag
    /// </summary>
    public RBarkConvoAction_Cond_SpeakerFlag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction_Cond_SpeakerFlag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction_Cond_SpeakerFlag(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetOutputIndex
    /// </summary>
    public unsafe int GetOutputIndex()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_Cond_SpeakerFlag.GetOutputIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// ByteProperty: FlagType
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkValDef.FlagTypeEnum FlagType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkValDef.FlagTypeEnum>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: PawnRef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvoPawnRef PawnRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoPawnRef>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
}

#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MSeqAct_SetSharedFlag<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MSeqAct_SetSharedFlag : BmSDK.Engine.SeqAct_SetSequenceVariable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MSeqAct_SetSharedFlag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MSeqAct_SetSharedFlag() { }

    /// <summary>
    /// Constructs a new MSeqAct_SetSharedFlag
    /// </summary>
    public MSeqAct_SetSharedFlag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSeqAct_SetSharedFlag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSeqAct_SetSharedFlag(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: SharedFlagName
    /// </summary>
    public unsafe BmSDK.FString SharedFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}

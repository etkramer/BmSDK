#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ChangeDebugLabelText<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ChangeDebugLabelText : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ChangeDebugLabelText", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ChangeDebugLabelText() { }

    /// <summary>
    /// Constructs a new RSeqAct_ChangeDebugLabelText
    /// </summary>
    public RSeqAct_ChangeDebugLabelText(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ChangeDebugLabelText Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ChangeDebugLabelText(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Text
    /// </summary>
    public unsafe BmSDK.FString Text
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: Int
    /// </summary>
    public unsafe int Int
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}

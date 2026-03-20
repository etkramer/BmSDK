#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_IsDefaultPlayerSkin<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_IsDefaultPlayerSkin : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_IsDefaultPlayerSkin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_IsDefaultPlayerSkin() { }

    /// <summary>
    /// Constructs a new RSeqAct_IsDefaultPlayerSkin
    /// </summary>
    public RSeqAct_IsDefaultPlayerSkin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_IsDefaultPlayerSkin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_IsDefaultPlayerSkin(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CharacterId
    /// </summary>
    public unsafe BmSDK.FString CharacterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}

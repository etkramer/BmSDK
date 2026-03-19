#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_UpdatePlayerSkin<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_UpdatePlayerSkin : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_UpdatePlayerSkin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_UpdatePlayerSkin() { }

    /// <summary>
    /// Constructs a new RSeqAct_UpdatePlayerSkin
    /// </summary>
    public RSeqAct_UpdatePlayerSkin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_UpdatePlayerSkin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_UpdatePlayerSkin(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CharacterId
    /// </summary>
    public unsafe BmSDK.FString CharacterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: SkinName
    /// </summary>
    public unsafe BmSDK.FString SkinName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}

#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetExtendableHudVisibility<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetExtendableHudVisibility : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetExtendableHudVisibility", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetExtendableHudVisibility() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetExtendableHudVisibility
    /// </summary>
    public RSeqAct_SetExtendableHudVisibility(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetExtendableHudVisibility Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetExtendableHudVisibility(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MoviePackage
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MoviePackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: MovieString
    /// </summary>
    public unsafe BmSDK.FString MovieString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}

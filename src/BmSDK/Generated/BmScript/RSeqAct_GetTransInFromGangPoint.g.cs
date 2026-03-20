#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_GetTransInFromGangPoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_GetTransInFromGangPoint : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_GetTransInFromGangPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_GetTransInFromGangPoint() { }

    /// <summary>
    /// Constructs a new RSeqAct_GetTransInFromGangPoint
    /// </summary>
    public RSeqAct_GetTransInFromGangPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_GetTransInFromGangPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_GetTransInFromGangPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RiotPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGangInteractPointBase RiotPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointBase>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: AnimNameString
    /// </summary>
    public unsafe BmSDK.FString AnimNameString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}

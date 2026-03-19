#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ComboValueReached<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ComboValueReached : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ComboValueReached", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ComboValueReached() { }

    /// <summary>
    /// Constructs a new RSeqAct_ComboValueReached
    /// </summary>
    public RSeqAct_ComboValueReached(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ComboValueReached Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ComboValueReached(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ComboValue
    /// </summary>
    public unsafe int ComboValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: RPCC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPCC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bCurrentlyActive
    /// </summary>
    public unsafe bool bCurrentlyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }
}

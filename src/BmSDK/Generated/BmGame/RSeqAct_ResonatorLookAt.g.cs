#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ResonatorLookAt<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ResonatorLookAt : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ResonatorLookAt", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ResonatorLookAt() { }

    /// <summary>
    /// Constructs a new RSeqAct_ResonatorLookAt
    /// </summary>
    public RSeqAct_ResonatorLookAt(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ResonatorLookAt Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ResonatorLookAt(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Instigator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Instigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: LookAt
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: TransitionTime
    /// </summary>
    public unsafe float TransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: CameraDuration
    /// </summary>
    public unsafe float CameraDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
}

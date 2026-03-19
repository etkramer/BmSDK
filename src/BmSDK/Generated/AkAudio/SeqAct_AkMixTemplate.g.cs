#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkMixTemplate<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkMixTemplate : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkMixTemplate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkMixTemplate() { }

    /// <summary>
    /// Constructs a new SeqAct_AkMixTemplate
    /// </summary>
    public SeqAct_AkMixTemplate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkMixTemplate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkMixTemplate(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MixTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MixTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: mCurrentlySet
    /// </summary>
    public unsafe bool mCurrentlySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }
}

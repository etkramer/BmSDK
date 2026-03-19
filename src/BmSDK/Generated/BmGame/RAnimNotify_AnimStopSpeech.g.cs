#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_AnimStopSpeech<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_AnimStopSpeech : BmSDK.BmGame.RAnimNotify_Script, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_AnimStopSpeech", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_AnimStopSpeech() { }

    /// <summary>
    /// Constructs a new RAnimNotify_AnimStopSpeech
    /// </summary>
    public RAnimNotify_AnimStopSpeech(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_AnimStopSpeech Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_AnimStopSpeech(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: EnableExitNotify
    /// </summary>
    public unsafe bool EnableExitNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// NameProperty: ExitNotifyName
    /// </summary>
    public unsafe BmSDK.FName ExitNotifyName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}

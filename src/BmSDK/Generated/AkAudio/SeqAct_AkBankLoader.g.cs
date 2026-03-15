#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkBankLoader<br/>
/// (size = 212)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_AkBankLoader : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkBankLoader", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkBankLoader() { }

    /// <summary>
    /// Constructs a new SeqAct_AkBankLoader
    /// </summary>
    public SeqAct_AkBankLoader(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkBankLoader Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkBankLoader(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SoundBank
    /// </summary>
    public unsafe BmSDK.Engine.AkBank SoundBank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkBank>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: IsBankLoaded
    /// </summary>
    public unsafe bool IsBankLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }
}

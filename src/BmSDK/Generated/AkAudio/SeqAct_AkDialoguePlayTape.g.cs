#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkDialoguePlayTape<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkDialoguePlayTape : BmSDK.AkAudio.SeqAct_AkBaseSimple, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkDialoguePlayTape", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkDialoguePlayTape() { }

    /// <summary>
    /// Constructs a new SeqAct_AkDialoguePlayTape
    /// </summary>
    public SeqAct_AkDialoguePlayTape(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkDialoguePlayTape Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkDialoguePlayTape(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Tape
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Tape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: Proxy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Proxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ArrayProperty: Speakers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> Speakers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: Playing
    /// </summary>
    public unsafe bool Playing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }
}

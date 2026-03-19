#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkDialogueResetDucking<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkDialogueResetDucking : BmSDK.AkAudio.SeqAct_AkBaseSimple, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkDialogueResetDucking", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkDialogueResetDucking() { }

    /// <summary>
    /// Constructs a new SeqAct_AkDialogueResetDucking
    /// </summary>
    public SeqAct_AkDialogueResetDucking(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkDialogueResetDucking Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkDialogueResetDucking(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: HandlerName
    /// </summary>
    public unsafe BmSDK.FName HandlerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bCallHandler
    /// </summary>
    public unsafe bool bCallHandler
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 332); }
    }

    /// <summary>
    /// ArrayProperty: Targets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> Targets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
}

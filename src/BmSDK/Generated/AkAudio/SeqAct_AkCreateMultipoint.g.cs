#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkCreateMultipoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkCreateMultipoint : BmSDK.AkAudio.SeqAct_AkBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkCreateMultipoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkCreateMultipoint() { }

    /// <summary>
    /// Constructs a new SeqAct_AkCreateMultipoint
    /// </summary>
    public SeqAct_AkCreateMultipoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkCreateMultipoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkCreateMultipoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: NodeIDs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> NodeIDs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: NetworkName
    /// </summary>
    public unsafe BmSDK.FString NetworkName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}

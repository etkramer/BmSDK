#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_GFxMovieUI<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_GFxMovieUI : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_GFxMovieUI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_GFxMovieUI() { }

    /// <summary>
    /// Constructs a new RSeqAct_GFxMovieUI
    /// </summary>
    public RSeqAct_GFxMovieUI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_GFxMovieUI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_GFxMovieUI(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TheMovieInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TheMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: RenderTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RenderTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: MovieUI
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ClassProperty: TheClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TheClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ByteProperty: RenderTextureMode
    /// </summary>
    public unsafe byte RenderTextureMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StrProperty: BackScreenCmd
    /// </summary>
    public unsafe BmSDK.FString BackScreenCmd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: AssetReferences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> AssetReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
}

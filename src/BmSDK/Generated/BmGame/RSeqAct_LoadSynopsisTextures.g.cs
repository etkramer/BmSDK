#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_LoadSynopsisTextures<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_LoadSynopsisTextures : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_LoadSynopsisTextures", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_LoadSynopsisTextures() { }

    /// <summary>
    /// Constructs a new RSeqAct_LoadSynopsisTextures
    /// </summary>
    public RSeqAct_LoadSynopsisTextures(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_LoadSynopsisTextures Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_LoadSynopsisTextures(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: TextureRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Texture2D> TextureRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Texture2D>>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StrProperty: PkgRef
    /// </summary>
    public unsafe BmSDK.FString PkgRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }
}

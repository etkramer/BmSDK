#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_EnsureChunkInstalled<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_EnsureChunkInstalled : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_EnsureChunkInstalled", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_EnsureChunkInstalled() { }

    /// <summary>
    /// Constructs a new RSeqAct_EnsureChunkInstalled
    /// </summary>
    public RSeqAct_EnsureChunkInstalled(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_EnsureChunkInstalled Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_EnsureChunkInstalled(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: InstallChunkRequired
    /// </summary>
    public unsafe byte InstallChunkRequired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: TheGFxMovieInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TheGFxMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ObjectProperty: MovieUI
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
}

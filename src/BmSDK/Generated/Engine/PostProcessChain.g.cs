#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PostProcessChain<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class PostProcessChain : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PostProcessChain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PostProcessChain() { }

    /// <summary>
    /// Constructs a new PostProcessChain
    /// </summary>
    public PostProcessChain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PostProcessChain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PostProcessChain(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Effects
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Effects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}

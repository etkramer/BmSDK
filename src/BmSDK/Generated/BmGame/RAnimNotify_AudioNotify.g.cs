#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_AudioNotify<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_AudioNotify : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_AudioNotify", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_AudioNotify() { }

    /// <summary>
    /// Constructs a new RAnimNotify_AudioNotify
    /// </summary>
    public RAnimNotify_AudioNotify(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_AudioNotify Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_AudioNotify(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Type
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}

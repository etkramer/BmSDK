#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// Class: GFxAction_CloseMovie<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GFxAction_CloseMovie : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.GFxAction_CloseMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxAction_CloseMovie() { }

    /// <summary>
    /// Constructs a new GFxAction_CloseMovie
    /// </summary>
    public GFxAction_CloseMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxAction_CloseMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxAction_CloseMovie(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Movie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Movie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bUnload
    /// </summary>
    public unsafe bool bUnload
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }
}

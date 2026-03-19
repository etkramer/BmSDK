#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: BookMark<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class BookMark : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.BookMark", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal BookMark() { }

    /// <summary>
    /// Constructs a new BookMark
    /// </summary>
    public BookMark(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, BookMark Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected BookMark(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: HiddenLevels
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT HiddenLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}

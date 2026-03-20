#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: BookMark2D<br/>
/// (size = 96)
/// (flags = 134217874)
/// </summary>
public partial class BookMark2D : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.BookMark2D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal BookMark2D() { }

    /// <summary>
    /// Constructs a new BookMark2D
    /// </summary>
    public BookMark2D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, BookMark2D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected BookMark2D(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Zoom2D
    /// </summary>
    public unsafe float Zoom2D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe BmSDK.GameObject.FIntPoint Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FIntPoint>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}

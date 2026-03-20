#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: KismetBookMark<br/>
/// (size = 112)
/// (flags = 0)
/// </summary>
public partial class KismetBookMark : BmSDK.Engine.BookMark2D, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.KismetBookMark", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal KismetBookMark() { }

    /// <summary>
    /// Constructs a new KismetBookMark
    /// </summary>
    public KismetBookMark(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, KismetBookMark Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected KismetBookMark(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: BookMarkSequencePathName
    /// </summary>
    public unsafe BmSDK.FString BookMarkSequencePathName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}

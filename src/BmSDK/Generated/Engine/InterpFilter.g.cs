#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpFilter<br/>
/// (size = 56)
/// (flags = 134217874)
/// </summary>
public partial class InterpFilter : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpFilter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpFilter() { }

    /// <summary>
    /// Constructs a new InterpFilter
    /// </summary>
    public InterpFilter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpFilter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpFilter(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Caption
    /// </summary>
    public unsafe BmSDK.FString Caption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}

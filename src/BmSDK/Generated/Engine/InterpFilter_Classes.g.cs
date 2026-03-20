#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpFilter_Classes<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpFilter_Classes : BmSDK.Engine.InterpFilter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpFilter_Classes", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpFilter_Classes() { }

    /// <summary>
    /// Constructs a new InterpFilter_Classes
    /// </summary>
    public InterpFilter_Classes(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpFilter_Classes Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpFilter_Classes(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: ClassToFilterBy
    /// </summary>
    public unsafe BmSDK.Class ClassToFilterBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: NamedClassesToFilterBy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> NamedClassesToFilterBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: TrackClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> TrackClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}

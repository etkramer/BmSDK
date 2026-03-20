#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: MetaData<br/>
/// (size = 156)
/// (flags = 0)
/// </summary>
public partial class MetaData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.MetaData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MetaData() { }

    /// <summary>
    /// Constructs a new MetaData
    /// </summary>
    public MetaData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MetaData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MetaData(nint ptr) : base(ptr) { }

}

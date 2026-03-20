#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UmbraData<br/>
/// (flags = 0)
/// </summary>
public partial class UmbraData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UmbraData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UmbraData() { }

    /// <summary>
    /// Constructs a new UmbraData
    /// </summary>
    public UmbraData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UmbraData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UmbraData(nint ptr) : base(ptr) { }

}

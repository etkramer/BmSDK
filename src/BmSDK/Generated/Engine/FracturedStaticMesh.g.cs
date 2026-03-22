#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FracturedStaticMesh<br/>
/// (size = 672)
/// (flags = 268443840)
/// </summary>
public partial class FracturedStaticMesh : BmSDK.Engine.StaticMesh, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FracturedStaticMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FracturedStaticMesh() { }

    /// <summary>
    /// Constructs a new FracturedStaticMesh
    /// </summary>
    public FracturedStaticMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FracturedStaticMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FracturedStaticMesh(nint ptr) : base(ptr) { }

}

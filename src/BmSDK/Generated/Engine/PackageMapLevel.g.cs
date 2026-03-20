#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PackageMapLevel<br/>
/// (flags = 0)
/// </summary>
public partial class PackageMapLevel : BmSDK.PackageMap, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PackageMapLevel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PackageMapLevel() { }

    /// <summary>
    /// Constructs a new PackageMapLevel
    /// </summary>
    public PackageMapLevel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PackageMapLevel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PackageMapLevel(nint ptr) : base(ptr) { }

}

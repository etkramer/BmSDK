#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PhysicalMaterialPropertyBase<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class PhysicalMaterialPropertyBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PhysicalMaterialPropertyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PhysicalMaterialPropertyBase() { }

    /// <summary>
    /// Constructs a new PhysicalMaterialPropertyBase
    /// </summary>
    public PhysicalMaterialPropertyBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PhysicalMaterialPropertyBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PhysicalMaterialPropertyBase(nint ptr) : base(ptr) { }

}

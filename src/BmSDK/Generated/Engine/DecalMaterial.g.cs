#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DecalMaterial<br/>
/// (flags = 0)
/// </summary>
public partial class DecalMaterial : BmSDK.Engine.Material, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DecalMaterial", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DecalMaterial() { }

    /// <summary>
    /// Constructs a new DecalMaterial
    /// </summary>
    public DecalMaterial(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DecalMaterial Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DecalMaterial(nint ptr) : base(ptr) { }

}

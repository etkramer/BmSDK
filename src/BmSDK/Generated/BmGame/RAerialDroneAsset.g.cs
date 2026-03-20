#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAerialDroneAsset<br/>
/// (size = 140)
/// (flags = 134221970)
/// </summary>
public partial class RAerialDroneAsset : BmSDK.BmGame.RThreatBaseAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAerialDroneAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAerialDroneAsset() { }

    /// <summary>
    /// Constructs a new RAerialDroneAsset
    /// </summary>
    public RAerialDroneAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAerialDroneAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAerialDroneAsset(nint ptr) : base(ptr) { }

}

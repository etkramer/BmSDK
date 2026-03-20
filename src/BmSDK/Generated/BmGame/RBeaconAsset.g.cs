#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBeaconAsset<br/>
/// (size = 140)
/// (flags = 134221970)
/// </summary>
public partial class RBeaconAsset : BmSDK.BmGame.RThreatBaseAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBeaconAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBeaconAsset() { }

    /// <summary>
    /// Constructs a new RBeaconAsset
    /// </summary>
    public RBeaconAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBeaconAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBeaconAsset(nint ptr) : base(ptr) { }

}

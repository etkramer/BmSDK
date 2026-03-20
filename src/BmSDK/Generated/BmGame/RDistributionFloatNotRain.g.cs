#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDistributionFloatNotRain<br/>
/// (size = 144)
/// (flags = 134230162)
/// </summary>
public partial class RDistributionFloatNotRain : BmSDK.BmGame.RDistributionFloatRain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDistributionFloatNotRain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDistributionFloatNotRain() { }

    /// <summary>
    /// Constructs a new RDistributionFloatNotRain
    /// </summary>
    public RDistributionFloatNotRain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDistributionFloatNotRain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDistributionFloatNotRain(nint ptr) : base(ptr) { }

}

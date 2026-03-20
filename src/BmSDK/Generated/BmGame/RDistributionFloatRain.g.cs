#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDistributionFloatRain<br/>
/// (size = 144)
/// (flags = 134230162)
/// </summary>
public partial class RDistributionFloatRain : BmSDK.Engine.DistributionFloatParameterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDistributionFloatRain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDistributionFloatRain() { }

    /// <summary>
    /// Constructs a new RDistributionFloatRain
    /// </summary>
    public RDistributionFloatRain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDistributionFloatRain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDistributionFloatRain(nint ptr) : base(ptr) { }

}

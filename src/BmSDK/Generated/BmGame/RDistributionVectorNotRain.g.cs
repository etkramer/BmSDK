#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDistributionVectorNotRain<br/>
/// (size = 192)
/// (flags = 0)
/// </summary>
public partial class RDistributionVectorNotRain : BmSDK.BmGame.RDistributionVectorRain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDistributionVectorNotRain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDistributionVectorNotRain() { }

    /// <summary>
    /// Constructs a new RDistributionVectorNotRain
    /// </summary>
    public RDistributionVectorNotRain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDistributionVectorNotRain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDistributionVectorNotRain(nint ptr) : base(ptr) { }

}

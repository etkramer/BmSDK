#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: REnvironmentCheckTicker<br/>
/// (size = 76)
/// (flags = 134217874)
/// </summary>
public partial class REnvironmentCheckTicker : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.REnvironmentCheckTicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal REnvironmentCheckTicker() { }

    /// <summary>
    /// Constructs a new REnvironmentCheckTicker
    /// </summary>
    public REnvironmentCheckTicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, REnvironmentCheckTicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected REnvironmentCheckTicker(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bGrappleGunTicker
    /// </summary>
    public unsafe bool bGrappleGunTicker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }
}

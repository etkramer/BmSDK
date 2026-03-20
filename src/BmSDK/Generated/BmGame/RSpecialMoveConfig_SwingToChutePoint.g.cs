#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_SwingToChutePoint<br/>
/// (size = 576)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_SwingToChutePoint : BmSDK.BmGame.RSpecialMoveConfig_SwingToVantagePoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_SwingToChutePoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_SwingToChutePoint() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_SwingToChutePoint
    /// </summary>
    public RSpecialMoveConfig_SwingToChutePoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_SwingToChutePoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_SwingToChutePoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ChuteTransitionMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ChuteTransitionMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }
}
